dotnet publish -c Release -f net10.0 -r linux-x64 --no-self-contained
(cd bin/Release/net10.0/linux-x64/publish && zip -ur "$OLDPWD/ArdoJSON.zip" .)