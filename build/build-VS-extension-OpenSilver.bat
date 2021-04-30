@echo off

rem Define the escape character for colored text
for /F %%a in ('"prompt $E$S & echo on & for %%b in (1) do rem"') do set "ESC=%%a"

rem Get the current date and time:
for /F "tokens=2" %%i in ('date /t') do set currentdate=%%i
set currenttime=%time%

rem Create a Version.txt file with the date:
md temp
@echo OpenSilver VS extension (%currentdate% %currenttime%)> temp/Version.txt

echo. 
echo %ESC%[95mRestoring NuGet packages%ESC%[0m
echo. 
nuget restore ../src/VSExtension/VSExtension.OpenSilver.sln -MSBuildVersion 14

echo. 
echo %ESC%[95mBuilding %ESC%[0mVSIX %ESC%[0m
echo. 
msbuild ../src/VSExtension/VSExtension.OpenSilver.sln -p:Configuration=Release -p:VisualStudioVersion=14.0
echo. 
echo %ESC%[95mCopying %ESC%[0mOpenSilver.vsix %ESC%[95mto output folder%ESC%[0m
echo. 
xcopy ..\src\VSExtension\OpenSilver.VSIX\bin\OpenSilver\Release\OpenSilver.vsix output\OpenSilver\ /Y

explorer "output\OpenSilver"

pause
