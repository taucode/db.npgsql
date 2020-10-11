using System.Data;

namespace TauCode.Db.Npgsql
{
    public class NpgsqlSerializer : DbSerializerBase
    {
        public NpgsqlSerializer(IDbConnection connection, string schemaName)
            : base(connection, schemaName)
        {
        }

        public override IDbUtilityFactory Factory => NpgsqlUtilityFactory.Instance;
    }
}
