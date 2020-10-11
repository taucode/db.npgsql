using System.Collections.Generic;
using System.Data;
using System.Linq;

// todo nice look
namespace TauCode.Db.Npgsql
{
    public class NpgsqlInspector : DbInspectorBase
    {
        #region Constants

        public const string DefaultSchemaName = "public";

        #endregion

        #region Constructor

        public NpgsqlInspector(IDbConnection connection, string schemaName)
            : base(connection, schemaName ?? DefaultSchemaName)
        {
        }

        #endregion

        public override IDbUtilityFactory Factory => NpgsqlUtilityFactory.Instance;

        protected override IReadOnlyList<string> GetTableNamesImpl(string schemaName)
        {
            using var command = this.Connection.CreateCommand();
            var sql =
                $@"
SELECT
    T.table_name TableName
FROM
    information_schema.tables T
WHERE
    T.table_type = 'BASE TABLE' AND
    T.table_schema = @p_schemaName
";

            command.AddParameterWithValue("p_schemaName", schemaName);

            command.CommandText = sql;

            var tableNames = DbTools
                .GetCommandRows(command)
                .Select(x => (string)x.TableName)
                .ToArray();

            return tableNames;
        }

        protected override HashSet<string> GetSystemSchemata()
        {
            throw new System.NotImplementedException();
        }
    }
}
