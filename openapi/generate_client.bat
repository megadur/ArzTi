@echo off
SET ADD_PROP=
::SET ADD_PROP=%ADD_PROP%classModifier=abstract,
::SET ADD_PROP=%ADD_PROP%swashbuckleVersion=5.0.0,
::SET ADD_PROP=%ADD_PROP%operationResultTask=true,
::SET ADD_PROP=%ADD_PROP%targetFramework=net5.0,
SET ADD_PROP=%ADD_PROP%packageName=ArzTiClient,
::SET ADD_PROP=%ADD_PROP%operationIsAsync=true,
::SET ADD_PROP=%ADD_PROP%buildTarget=library,
::SET ADD_PROP=%ADD_PROP%isLibrary=true,


SET INFILE="ArzTi-swagger.yaml"
SET OUTFILE="../ArzTiClient.Api"

::del %OUTFILE% /Q

openapi-generator-cli generate -i %INFILE% -g csharp -o %OUTFILE% --additional-properties=%ADD_PROP% 


pause