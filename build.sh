#!/usr/bin/env bash

set -euo pipefail
IFS=$'\n\t'

usage() {
    echo "usage: $0 [options]"
    echo "options:"
    echo "  --with-packages <dir>              use the specified archive of source-built packages to build."
    echo "  --with-sdk <dir>                   use the specified SDK to build."
}

function abspath() {
    # $1 : relative filename
    parentdir=$(dirname "$1")

    if [ -d "$1" ]; then
        (cd "$1" && pwd)
    elif [ -d "${parentdir}" ]; then
        echo "$(cd "${parentdir}" && pwd)/$(basename "$1")"
    fi
}

__scriptpath=$(cd "$(dirname "$0")"; pwd -P)
__log_path="$__scriptpath/artifacts/log"

CUSTOM_SDK_DIR=''
CUSTOM_SOURCE_BUILT_PACKAGES=''

while :; do
    if [ $# -le 0 ]; then
        break
    fi

    lowerI="$(echo "$1" | awk '{print tolower($0)}')"
    case $lowerI in
        --with-sdk)
            CUSTOM_SDK_DIR="$2"
            if [ ! -d "$CUSTOM_SDK_DIR" ]; then
                echo "Custom SDK directory '$CUSTOM_SDK_DIR' does not exist"
            fi
            if [ ! -x "$CUSTOM_SDK_DIR/dotnet" ]; then
                echo "Custom SDK '$CUSTOM_SDK_DIR/dotnet' not found or not executable"
            fi
            CUSTOM_SDK_DIR="$(abspath "$CUSTOM_SDK_DIR")"
            shift
            ;;
        --with-packages)
            CUSTOM_SOURCE_BUILT_PACKAGES="$2"
            if [ ! -f "$CUSTOM_SOURCE_BUILT_PACKAGES" ]; then
                echo "Custom source-built packages file '$CUSTOM_SOURCE_BUILT_PACKAGES' does not exist"
                exit 1
            fi
            CUSTOM_SOURCE_BUILT_PACKAGES="$(abspath "$CUSTOM_SOURCE_BUILT_PACKAGES")"
            shift
            ;;
        "-?"|-h|--help)
            usage
            exit 0
            ;;
        *)
            echo "Unrecognized argument '$1'"
            usage
            exit 1
            ;;
    esac

    shift
done

if [ -n "${CUSTOM_SDK_DIR}" ]; then
    rm -rf "$__scriptpath/.dotnet"
    # TODO we could use ln -s to save space/time, if we never need to write to this directory
    cp -a "${CUSTOM_SDK_DIR}" "$__scriptpath/.dotnet"
    sdk_version="$(basename "$(find "${CUSTOM_SDK_DIR}/sdk" -maxdepth 1 -type d -printf "%p\n" | sort -rn | head -1)")"
    echo "Found SDK version $sdk_version in ${CUSTOM_SDK_DIR}"
    sed -i -e "s|\"dotnet\" *: *\".*\"|\"dotnet\": \"$sdk_version\"|" global.json
fi


if [ -n "${CUSTOM_SOURCE_BUILT_PACKAGES}" ]; then
    mkdir -p source-built
    (cd source-built && tar xf "${CUSTOM_SOURCE_BUILT_PACKAGES}")
fi

# Use Arcade script to initialize dotnet cli only
source ./eng/common/tools.sh
InitializeDotNetCli true

export __DOTNET_CMD="$_InitializeDotNetCli/dotnet"
__SDK_PATH="$DOTNET_INSTALL_DIR/sdk/$_ReadGlobalVersion"

export RepoRoot="$__scriptpath/"

$__DOTNET_CMD "$__SDK_PATH/MSBuild.dll" "$__scriptpath/src/targetPacks/buildTargettingPackages.proj" /m /bl:"$__log_path/BuildTargettingPackages.binlog" "$@"
$__DOTNET_CMD "$__SDK_PATH/MSBuild.dll" "$__scriptpath/src/referencePackages/buildReferencePackages.proj" /bl:"$__log_path/BuildReferencePackages.binlog" "$@"
