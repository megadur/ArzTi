@echo off 
setlocal EnableExtensions DisableDelayedExpansion

set "search=[ValidateModelState]"
set "replace=[ValidateModelState] [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]"

set "textFile=*Api.cs"
set "rootDir=..\ArzTiServer\Api\Controllers"
echo %rootDir%\%textFile%
for %%j in ("%rootDir%\%textFile%") do (
    for /f "delims=" %%i in ('type "%%~j" ^& break ^> "%%~j"') do (
        set "line=%%i"
        setlocal EnableDelayedExpansion
        set "line=!line:%search%=%replace%!"
        >>"%%~j" echo(!line!
        endlocal
    )
)

endlocal