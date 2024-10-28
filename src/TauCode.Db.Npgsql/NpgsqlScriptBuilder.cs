namespace TauCode.Db.Npgsql;

public class NpgsqlScriptBuilder : ScriptBuilder
{
    #region Overridden

    public override IUtilityFactory Factory => NpgsqlUtilityFactory.Instance;

    #endregion
}