@echo off
echo =======================================================
echo   Starting Clothes Shop (Q1 Cloth Sale App)
echo =======================================================
echo.
echo Restoring NuGet packages and compiling solution...
dotnet build ClothesShop.sln
if %ERRORLEVEL% NEQ 0 (
    echo.
    echo [ERROR] Build failed! Please make sure the .NET 10 SDK is installed on this machine.
    echo.
    pause
    exit /b %ERRORLEVEL%
)
echo.
echo Launching Q1 Cloth Sale WinForms GUI...
dotnet run --project ClothesShop.WinForms/ClothesShop.WinForms.csproj --no-build
echo.
pause
