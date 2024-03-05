dotnet build
dotnet test
dotnet publish -r win-x64 --self-contained true -o ./publish
Compress-Archive -Path ./publish -DestinationPath "publish.zip" -Force 