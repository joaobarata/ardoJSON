dotnet publish -c Release -r linux-x64 --self-contained false
Compress-Archive -Path .\bin\Release\net10.0\linux-x64\publish\* -DestinationPath ArdoJSON.zip -force