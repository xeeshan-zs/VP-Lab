@echo off
echo =======================================================
echo   Starting Furniture Hub MVC Web App ^& Web API
echo =======================================================
echo.
echo Restoring NuGet packages and compiling web solution...
dotnet build FurnitureHub.sln
if %ERRORLEVEL% NEQ 0 (
    echo.
    echo [ERROR] Build failed! Please make sure the .NET 10 SDK is installed on this machine.
    echo.
    pause
    exit /b %ERRORLEVEL%
)
echo.
echo [1/3] Starting Furniture Hub Web API (Port 5100) in a new window...
start "FurnitureHub Web API (Port 5100)" dotnet run --project FurnitureHub.Api/FurnitureHub.Api.csproj --urls "http://localhost:5100" --no-build

echo.
echo [2/3] Waiting for Web API and EF Core Code-First to initialize database...
timeout /t 5 /nobreak > NUL

echo.
echo [3/3] Starting Furniture Hub MVC Web Client (Port 5200) in a new window...
start "FurnitureHub MVC Web Client (Port 5200)" dotnet run --project FurnitureHub.Mvc/FurnitureHub.Mvc.csproj --urls "http://localhost:5200" --no-build

echo.
echo [COMPLETE] Launching web browser to: http://localhost:5200 ...
timeout /t 2 /nobreak > NUL
start http://localhost:5200

echo.
echo =======================================================
echo   Both services are now running successfully!
echo   * Web API active at:  http://localhost:5100
echo   * MVC Client active at: http://localhost:5200
echo =======================================================
echo.
echo Keep this window open if you want to read logs. Press any key to stop.
pause
