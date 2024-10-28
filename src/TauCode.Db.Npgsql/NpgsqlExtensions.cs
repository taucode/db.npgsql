namespace TauCode.Db.Npgsql;

public static class NpgsqlExtensions
{
    public static void DropSchema(this NpgsqlExplorer explorer, string schemaName, bool forceDropSchemaTables = false)
    {
        if (forceDropSchemaTables)
        {
            var tableNames = explorer.GetTableNames(schemaName);
            if (tableNames.Any())
            {
                throw new NotImplementedException();
            }
        }

        explorer.GetOpenConnection().ExecuteSql(@$"DROP SCHEMA {schemaName}");
    }

    public static void ProcessJson(this NpgsqlInstructionProcessor processor, string json)
    {
        // todo checks

        var instructionReader = new JsonInstructionReader();
        using var jsonTextReader = new StringReader(json);

        var instructions = instructionReader.ReadInstructions(jsonTextReader);

        processor.Process(instructions);
    }
}
