namespace TauCode.Db.Npgsql;

public class NpgsqlDialect : Dialect
{
    public override IUtilityFactory Factory => NpgsqlUtilityFactory.Instance;
    public override string Name => "SQL Server";

    public override string Undelimit(string identifier)
    {
        // todo temp!

        return identifier.Replace("[", "").Replace("]", "");
    }
}
