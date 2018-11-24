cd /d "C:\Users\linux\source\repos\DomeLauncher\DomeLauncher" &msbuild "DomeLauncher.vbproj" /t:sdvViewer /p:configuration="Debug" /p:platform=Any CPU
exit %errorlevel% 