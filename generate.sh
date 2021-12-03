#!/usr/bin/env bash
#set -x
source="${BASH_SOURCE[0]}"

# resolve $SOURCE until the file is no longer a symlink
while [[ -h $source ]]; do
  scriptroot="$( cd -P "$( dirname "$source" )" && pwd )"
  source="$(readlink "$source")"

  # if $source was a relative symlink, we need to resolve it relative to the path where the
  # symlink file was located
  [[ $source != /* ]] && source="$scriptroot/$source"
done

scriptroot="$( cd -P "$( dirname "$source" )" && pwd )"

GREEN='\033[0;32m'
RED='\033[0;31m'
NC='\033[0m'

usage() {
    echo "usage: $0 [options]"
    echo ""
    echo "  Restores reference package(s) and dependencies and generates cs files and accompanying projects"
    echo "  to build a reference package.  The generated artifacts are added to the /src/ directory of this repo"
    echo "  unless a different destination is specified.  If a csv file of packages is specified, multiple"
    echo "  packages and their dependencies are generated."
    echo ""
    echo "  Either --pkg or --pkgCsv must be specified"
    echo ""
    echo "options:"
    echo "  --pkg <packageName,version[,tfm]>  A package and version, no spaces, separated by comma.  If the optional"
    echo "                                       tfm is specified, it will be used in the project that restores the"
    echo "                                       package."
    echo "                                       Example: System.Text.Json,4.7.0"
    echo "  --pkgCsv <pathToCSV>               A path to a csv file of packages to generate. Format is the same as the --pkg"
    echo "                                       option above, one per line.  If specified, the --pkg option is ignored."
    echo "  --dest <pathToDestRepo>            A path to the root of the repo to copy source into."
    echo ""
}

packageVersion=
defaultPathToCSV="$scriptroot/artifacts/targetPackages.csv"
pathToCSV=
pathToDestRepo="$scriptroot"
positional_args=()
requiredOptionSpecified=false
while :; do
    if [ $# -le 0 ]; then
        break
    fi
    lowerI="$(echo "$1" | awk '{print tolower($0)}')"
    case $lowerI in
        "-?"|-h|--help)
            usage
            exit 0
            ;;
        --pkgcsv)
            if [ ! -f "$2" ]; then
                echo -e "${RED}ERROR: CSV file not found - $2${NC}"
                exit 1
            fi
            pathToCSV="$(cd "$(dirname "$2")"; pwd)/$(basename "$2")"
            requiredOptionSpecified=true
            shift
            ;;
        --dest)
            if [ ! -d "$2" ]; then
                echo -e "${RED}ERROR: dest not found - $2${NC}"
                exit 1
            fi
            pathToDestRepo="$(cd -P "$2" && pwd)"
            shift
            ;;
        --pkg)
            packageVersion="$2"
            requiredOptionSpecified=true
            shift
            ;;
        *)
            echo -e "${RED}Unrecognized argument '$1'${NC}"
            usage
            exit 1
            ;;
    esac

    shift
done

if [ "$requiredOptionSpecified" != "true" ]; then
    usage
    exit 1
fi

if [ "$packageVersion" != "" ]; then
    mkdir -p "$(dirname "$defaultPathToCSV")"
    echo "$packageVersion" > "$defaultPathToCSV"
fi

if [ "$pathToCSV" == "" ]; then
    pathToCSV="$defaultPathToCSV"
fi

# Generate restore projects for each target package
# Packges are restored in their own project to eliminate any conflicts
# between different versions of the same package.
INPUT="$pathToCSV"
OLDIFS=$IFS
IFS=,
DEFAULT_TFM=net6.0
restoreProjectsDir="$scriptroot/artifacts/targetRestoreProjects"
targetPackageTemplate="$scriptroot/src/referencePackageSourceGenerator/GenerateSource/targetPackage.csproj.template"
if [ -d "$restoreProjectsDir" ]; then
  rm -rf "$restoreProjectsDir"
fi
mkdir -p "$restoreProjectsDir"
[ ! -f $INPUT ] && { echo "$INPUT file not found"; exit 99; }
while read pkgName pkgVersion tfm
do
    sed "s/##PackageName##/${pkgName}/g" "$targetPackageTemplate" > "$restoreProjectsDir/$pkgName.$pkgVersion.csproj"
    sed -i "s/##PackageVersion##/${pkgVersion}/g" "$restoreProjectsDir/$pkgName.$pkgVersion.csproj"
    if [ "$tfm" != "" ]; then
        sed -i "s/##Tfm##/${tfm}/g" "$restoreProjectsDir/$pkgName.$pkgVersion.csproj"
    else
        sed -i "s/##Tfm##/${DEFAULT_TFM}/g" "$restoreProjectsDir/$pkgName.$pkgVersion.csproj"
    fi
done < $INPUT
IFS=$OLDIFS

# Build the projects to generate source and projects
"$scriptroot/eng/common/build.sh" --build --restore -bl /p:GeneratePackageSource=true /p:GeneratorVersion=2 $@

# Copy source to destination
pathToGeneratedSrc="$scriptroot/artifacts/generatedSrc"
pathToRepoSrc="$pathToDestRepo/src/referencePackages/src"

pushd "$pathToGeneratedSrc"
cp ./ProjectsToBuildAdditions.txt ./CopyProjects.sh
sed -i 's/    <ProjectsToBuild Include="$(ReferenceAssemblySourcePath)/cp -r --parents .\//g' CopyProjects.sh
sed -i 's/\/[^\/]*\/>/\/* $1/g' CopyProjects.sh
echo -e '\nfind . -type f -iname Directory.Build.props -exec cp --parents {} $1 \;' >> CopyProjects.sh
chmod 755 ./CopyProjects.sh
./CopyProjects.sh "$pathToRepoSrc"
popd

echo
echo -e "  Copied generated projects from ${GREEN}$pathToGeneratedSrc${NC} to ${GREEN}"$pathToRepoSrc"${NC}"
echo
