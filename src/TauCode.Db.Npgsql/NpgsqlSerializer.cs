using System.Data;

namespace TauCode.Db.Npgsql
{
    public class NpgsqlSerializer : DbSerializerBase
    {
        public NpgsqlSerializer(IDbConnection connection, string schema)
            : base(connection, schema)

        {
        }
        public override IDbUtilityFactory Factory => NpgsqlUtilityFactory.Instance;
    }
}
