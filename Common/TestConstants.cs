namespace Common
{
	public static class TestConstants
	{
		// Azdo = Azure DevOps

		public const string ConfigFileName = @"appsettings.test.json";

		// Integration Tests
		public const string EnvVarNameAzdoTestDbConnectionStringOverride = @"AZDO_TEST_DB_CONNECTION_STRING_OVERRIDE";
		public const string EnvVarNameAzdoTestDbIntegratedSecurity = @"AZDO_TEST_DB_INTEGRATED_SECURITY";
		public const string EnvVarNameAzdoTestDbServer = @"AZDO_TEST_DB_SERVER";
		public const string EnvVarNameAzdoTestDbPort = @"AZDO_TEST_DB_PORT";
		public const string EnvVarNameAzdoTestDbUserId = @"AZDO_TEST_DB_USERID";
		public const string EnvVarNameAzdoTestDbPassword = @"AZDO_TEST_DB_PASSOWRD";
		public const string EnvVarNameAzdoTestDbSecurityTokens = @"AZDO_TEST_DB_SECURITY_TOKENS";

		public const string DatabaseNameToken = @"{databaseName}";
	}
}