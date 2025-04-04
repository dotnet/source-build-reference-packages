@echo off
:: Check if pwsh (PowerShell Core) is available
where pwsh >nul 2>&1
if %ERRORLEVEL%==0 (
    pwsh -ExecutionPolicy ByPass -NoProfile -command "& """%~dp0eng\common\Build.ps1""" -restore -build -test -configuration Release %*"
) else (
    powershell -ExecutionPolicy ByPass -NoProfile -command "& """%~dp0eng\common\Build.ps1""" -restore -build -test -configuration Release %*"
)