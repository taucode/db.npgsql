namespace TauCode.Db.Npgsql;

// todo regions

public class NpgsqlUtilityFactory : IUtilityFactory
{
    public static NpgsqlUtilityFactory Instance { get; } = new();

    private NpgsqlUtilityFactory()
    {
    }

    public IDialect Dialect { get; } = new NpgsqlDialect();

    public IScriptBuilder CreateScriptBuilder() => new NpgsqlScriptBuilder();

    public IExplorer CreateExplorer() => new NpgsqlExplorer();

    public ICruder CreateCruder() => new NpgsqlCruder();
}