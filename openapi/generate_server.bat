@echo off
SET ADD_PROP=
SET ADD_PROP=%ADD_PROP%classModifier=abstract,
SET ADD_PROP=%ADD_PROP%swashbuckleVersion=5.0.0,
SET ADD_PROP=%ADD_PROP%operationResultTask=true,
SET ADD_PROP=%ADD_PROP%aspnetCoreVersion=5.0,
SET ADD_PROP=%ADD_PROP%packageName=ArzTiServer,
::SET ADD_PROP=%ADD_PROP%operationIsAsync=true,
::SET ADD_PROP=%ADD_PROP%buildTarget=library,
::SET ADD_PROP=%ADD_PROP%isLibrary=true,


SET INFILE="ArzTi-swagger.yaml"
SET OUTFILE="../ArzTiServer.Api"

::del %OUTFILE% /Q

openapi-generator-cli generate -i %INFILE% -g aspnetcore -o %OUTFILE% --additional-properties=%ADD_PROP% 


pause