:: Generated by: https://openapi-generator.tech
::

@echo off

dotnet restore src\ArzTiServer
dotnet build src\ArzTiServer
echo Now, run the following to start the project: dotnet run -p src\ArzTiServer\ArzTiServer.csproj --launch-profile web.
echo.
