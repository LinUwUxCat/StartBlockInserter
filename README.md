# StartBlockInserter
A TMNF tool that inserts a start block by replacing other blocks.

## How to use
Step 1 : get the latest build corresponding to your system at [the release page](https://github.com/LinUwUxCat/StartBlockInserter/releases)\
**On Windows :** Drag and drop your challenge file on the exe. A command window should open. Enter the path to your block like in-game (as an example, if it's the road ramp, you'll enter 2-3-8).\
**Any System :** In command line, the binary takes either 1 or 2 arguments. If only 1, it should be the challenge file's path. If 2 arguments are provided, they should be respectively the challenge file's path and the block path or block name.

## Compiling
Just copypaste this very long command i stole off some random website : `dotnet publish SBI.csproj --configuration Release --framework net5.0 --output publish --self-contained True --runtime win10-x64 --verbosity Normal /property:PublishTrimmed=True /property:PublishSingleFile=True /property:IncludeNativeLibrariesForSelfExtract=True /property:DebugType=None /property:DebugSymbols=False`\
Note : notice that there is `--runtime win10-x64`, you can change that for `linux-x64` if you need to compile on linux. Other systems aren't supported yet (i can't test anything) so you'll need to add some values yourself in SBI.csproj