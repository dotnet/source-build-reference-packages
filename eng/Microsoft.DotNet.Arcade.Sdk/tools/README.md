The source-build targets work roughly like this:

* `./build.sh /p:FromSource=true`
  * `dotnet msbuild ... Build.proj`
    * Execute...
      * [Hook] Before outer Execute:
        * Clone the source into `artifacts/source-build/self/src`
        * Assemble a build command by appending to the `dotnet msbuild` call.
        * `dotnet msbuild ... Build.proj ... /p:InnerBuildFromSource=true`
          * Inner Execute...
            * [Hook] Before inner Execute:
              * Compile source-build MSBuild tasks. (Temporary, should migrate to Arcade task DLL.)
            * During:
              * `MSBuild Projects=Tools.proj Targets=Restore`
                * [Hook] Inject intermediate nupkg package reference through MSBuild task.
                * [Hook] After Restore, copy the extracted source-built nupkgs to a new dir and inject the dir into the NuGet.config.
              * The build happens!
          * Inner Execute... complete! Inner source-build is done.
        * `MSBuild Projects=SourceBuildIntermediate.proj Targets=Restore;Pack`
          * This creates an intermediate nupkg that contains the inner source-build's outputs.
        * Before Execute starts, empty out the list of projects to build, because we already built them from source. Include `Noop.proj` as sentinel value.
      * During:
        * `MSBuild Projects=Tools.proj Targets=Restore`
          * Does nothing interesting.
          * If we can make this Restore happen *before* the source-build targets, then we should probably move intermediate nupkg restore here. Doing so would let devs use a global cache more easily and avoid mixing the intermediate nupkg into the inner build package cache.
        * Only builds `Noop.proj`: outer build does nothing.

`SourceBuildArcade.targets` is imported by `Build.props` to implement `Build.proj` hooks.

`SourceBuildArcadeTools.targets` is imported by `Tools.props` to implement `Tool.proj` hooks.
