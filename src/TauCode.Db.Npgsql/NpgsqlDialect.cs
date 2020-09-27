﻿namespace TauCode.Db.Npgsql
{
    [DbDialect(
        typeof(NpgsqlDialect),
        "reserved-words.txt",
        //"data-type-names.txt",
        "\"\"")]
    public class NpgsqlDialect : DbDialectBase
    {
        #region Static

        public static readonly NpgsqlDialect Instance = new NpgsqlDialect();

        #endregion

        #region Constructor

        private NpgsqlDialect()
            : base(DbProviderNames.PostgreSQL)
        {
        }

        #endregion

        #region Overridden

        public override IDbUtilityFactory Factory => NpgsqlUtilityFactory.Instance;
        
        public override string UnicodeTextLiteralPrefix => "N";

        public override bool CanDecorateTypeIdentifier => false;

        #endregion
    }
}
