# .NET Source-build Reference Packages

This repository contains source and build scripts for source-buildable reference versions of historical .NET Core packages that are referenced by the [source-build] repo.  These are used only when building the source-build repo.

## The `pre-arcade` branch

This branch doesn't implement [arcade-powered source-build]. Instead, it
generates outputs that are used indirectly by [source-build]. The outputs are
either downloaded as `tar.gz` files from Microsoft, or consumed from a specialty
distro package built separately from the rest of source-build.

`pre-arcade` is maintained for [source-build] branches still using the
pre-arcade approach.

### Continuous builds

Microsoft build outputs from this repo are published by Arcade to blob storage.
They are used by source-build when prebuilts are acceptable to avoid rebuilding
the repo. This repo doesn't change often, making a cache particularly useful.

### Build on Linux or MacOS

```
./build.sh
```

## License

This repo is licensed under the [MIT](LICENSE.txt) license.


[source-build]: https://github.com/dotnet/source-build
[arcade-powered source-build]: https://github.com/dotnet/source-build/tree/release/3.1/Documentation/planning/arcade-powered-source-build
