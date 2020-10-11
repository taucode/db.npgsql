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

        public IDbScriptBuilder CreateScriptBuilder(string schemaName) => new NpgsqlScriptBuilder(schemaName);
        public IDbConnection CreateConnection() => new NpgsqlConnection();

        public IDbInspector CreateInspector(IDbConnection connection, string schemaName) => new NpgsqlInspector(connection, schemaName);

        public IDbTableInspector CreateTableInspector(IDbConnection connection, string schemaName, string tableName) =>
            new NpgsqlTableInspector(connection, schemaName, tableName);

        public IDbCruder CreateCruder(IDbConnection connection, string schemaName) => new NpgsqlCruder(connection, schemaName);

        public IDbSerializer CreateSerializer(IDbConnection connection, string schemaName) => new NpgsqlSerializer(connection, schemaName);
    }
}
