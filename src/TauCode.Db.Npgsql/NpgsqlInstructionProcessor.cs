using Npgsql;

namespace TauCode.Db.Npgsql;

public class NpgsqlInstructionProcessor : InstructionProcessor
{
    #region ctor

    public NpgsqlInstructionProcessor()
    {

    }

    public NpgsqlInstructionProcessor(NpgsqlConnection connection)
        : base(connection)
    {

    }

    #endregion

    #region Overridden

    public override IUtilityFactory Factory => NpgsqlUtilityFactory.Instance;

    #endregion
}