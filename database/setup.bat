@echo off
rem Creates Database.accdb (with the test data from document 3.2) next to the built program.
rem Usage: setup.bat          -> database with test data
rem        setup.bat empty    -> empty database (no runners, no admin password)
setlocal
set "HERE=%~dp0"
for %%I in ("%HERE%..\src") do set "PROJ=%%~fI"
rem Remove the "downloaded from the internet" flag from the project files (fixes build error MSB3821).
powershell -NoProfile -Command "Get-ChildItem -LiteralPath '%PROJ%' -Recurse | Unblock-File"
for %%C in (Debug Release) do call :make %%C %1
echo.
echo Done. Now build and run the project in Visual Studio.
pause
exit /b

:make
if not exist "%PROJ%\bin\%1" mkdir "%PROJ%\bin\%1"
if exist "%PROJ%\bin\%1\Database.accdb" (
  echo bin\%1\Database.accdb already exists - skipped
  exit /b
)
cscript //nologo "%HERE%create_database.vbs" "%PROJ%\bin\%1\Database.accdb"
if /i not "%2"=="empty" cscript //nologo "%HERE%seed_test_data.vbs" "%PROJ%\bin\%1\Database.accdb"
exit /b
