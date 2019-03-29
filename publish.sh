#!/usr/bin/env bash

usage() {
    echo "Usage: $0 <OfficialBuildId> [extra build params]"
}

if [ -z "${1:-}" ]; then
    usage
    exit 1
fi

OfficialBuildId=$1
shift

buildParams="/p:DotNetBuildFromSource=true /p:OfficialBuildId=$OfficialBuildId"

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

"$scriptroot/eng/common/build.sh" --build --restore --pack -bl "$buildParams" $@
