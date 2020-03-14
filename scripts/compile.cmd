REM @echo off

IF EXIST .\compile.cmd cd ..

CALL scripts\environnement.cmd

scripts\nuget restore

REM --------------------------------------------------------
REM  MSBuild Strev.QuickTools.sln
REM --------------------------------------------------------
"%MSBUILD%" /t:Build   /p:Configuration=Debug;Platform="Any CPU" "Strev.QuickTools.Demo.sln" || exit /b -1
"%MSBUILD%" /t:Build /p:Configuration=Release;Platform="Any CPU" "Strev.QuickTools.Demo.sln" || exit /b -1
