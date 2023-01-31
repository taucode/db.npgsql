dotnet restore

dotnet build TauCode.Db.Npgsql.sln -c Debug
dotnet build TauCode.Db.Npgsql.sln -c Release

dotnet test TauCode.Db.Npgsql.sln -c Debug
dotnet test TauCode.Db.Npgsql.sln -c Release

nuget pack nuget\TauCode.Db.Npgsql.nuspec