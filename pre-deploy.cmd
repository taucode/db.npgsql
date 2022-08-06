dotnet restore

dotnet build --configuration Debug
dotnet build --configuration Release

dotnet test -c Debug .\test\TauCode.Db.Npgsql.Tests\TauCode.Db.Npgsql.Tests.csproj
dotnet test -c Release .\test\TauCode.Db.Npgsql.Tests\TauCode.Db.Npgsql.Tests.csproj

nuget pack nuget\TauCode.Db.Npgsql.nuspec