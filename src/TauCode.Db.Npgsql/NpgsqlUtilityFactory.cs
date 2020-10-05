using Npgsql;
using System.Data;

namespace TauCode.Db.Npgsql
{
    public class NpgsqlUtilityFactory : IDbUtilityFactory
    {
        public static NpgsqlUtilityFactory Instance { get; } = new NpgsqlUtilityFactory();

        private NpgsqlUtilityFactory()
        {
        }

        public IDbDialect GetDialect() => NpgsqlDialect.Instance;

        public IDbScriptBuilder CreateScriptBuilder(string schema) => new NpgsqlScriptBuilder(schema);
        public IDbConnection CreateConnection() => new NpgsqlConnection();

        public IDbInspector CreateInspector(IDbConnection connection, string schema) => new NpgsqlInspector(connection, schema);

        public IDbTableInspector CreateTableInspector(IDbConnection connection, string schema, string tableName) =>
            new NpgsqlTableInspector(connection, schema, tableName);

        public IDbCruder CreateCruder(IDbConnection connection, string schema) => new NpgsqlCruder(connection, schema);

        public IDbSerializer CreateSerializer(IDbConnection connection, string schema) => new NpgsqlSerializer(connection, schema);
    }
}
