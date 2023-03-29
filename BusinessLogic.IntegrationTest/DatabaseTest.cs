using BusinessLogic.Data;
using Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit.Abstractions;

namespace BusinessLogic.IntegrationTest
{
	public class DatabaseTests : IDisposable
	{
		private static string? EnvVarValueDbConnectionStringOverride =
			Environment.GetEnvironmentVariable(TestConstants.EnvVarNameAzdoTestDbConnectionStringOverride);
		
		private static readonly string? EnvVarValueDbIntegratedSecurity = 
			Environment.GetEnvironmentVariable(TestConstants.EnvVarNameAzdoTestDbIntegratedSecurity);
		
		private static readonly string? EnvVarValueDbServer = 
			Environment.GetEnvironmentVariable(TestConstants.EnvVarNameAzdoTestDbServer);
		
		private static readonly string? EnvVarValueDbPort = 
			Environment.GetEnvironmentVariable(TestConstants.EnvVarNameAzdoTestDbPort);
		
		private static readonly string? EnvVarValueDbUserId = 
			Environment.GetEnvironmentVariable(TestConstants.EnvVarNameAzdoTestDbUserId);
		
		private static readonly string? EnvVarValueDbPassword = 
			Environment.GetEnvironmentVariable(TestConstants.EnvVarNameAzdoTestDbPassword);

		private static readonly string? EnvVarValueDbSecurityTokens =
			Environment.GetEnvironmentVariable(TestConstants.EnvVarNameAzdoTestDbSecurityTokens);

		readonly MusicCatalogContext _context;
		private readonly ITestOutputHelper _output;

		public static IConfiguration InitConfiguration()
		{
			var config = new ConfigurationBuilder()
			   .AddJsonFile("appsettings.test.json")
               .AddEnvironmentVariables()
               .Build();
			return config;
		}

		public DatabaseTests(ITestOutputHelper output)
		{
			this._output = output;

			var config = InitConfiguration();

			var serviceProvider = new ServiceCollection()
				.AddEntityFrameworkSqlServer()
				.BuildServiceProvider();

			string connectionString = null;
			var builder = new DbContextOptionsBuilder<MusicCatalogContext>();
			string databaseName = "musiccatalogtests_" + Guid.NewGuid();

			if ( EnvVarValueDbIntegratedSecurity == "true")
			{
				// using Integrated Security for local testing which does not work in a DevOps pipeline
				connectionString = $"Server=(localdb)\\mssqllocaldb;Database=" + databaseName + ";Trusted_Connection=True;MultipleActiveResultSets=true";
				output.WriteLine("SQL Server Connection String to Local DB: " + connectionString);
			}
			else
			{
				// in any DevOps Pipeline you need some kind of remote SQL Server
				_output.WriteLine("Using Remote SQL Server...");

                var server = EnvVarValueDbServer ?? config["Database:Server"];
                var port = EnvVarValueDbPort ?? config["Database:Port"];
                var serverName = server + "," + port;
                var userName = EnvVarValueDbUserId ?? config["Database:UserId"];
				var password = EnvVarValueDbPassword ?? config["Database:Password"];
				// Refs https://github.com/dotnet/SqlClient/issues/1479
				var securityTokens = EnvVarValueDbSecurityTokens ?? config["Database:Password"];
				
				connectionString = EnvVarValueDbConnectionStringOverride?
					                   .Replace(TestConstants.DatabaseNameToken, databaseName) ?? 
				                   $"Server={serverName}; Database={databaseName}; User Id={userName}; Password={password}; {securityTokens}";
				
				output.WriteLine("SQL Server Connection String to remote DB: " + connectionString);
			}

			// **************************
			// this works!
			// connectionString = $"Server=localhost,1433; Database={databaseName}; User Id=SA; Password=P@ssword1$; TrustServerCertificate=True;MultiSubnetFailover=True";
			// ********************************************

			builder
				.UseSqlServer(connectionString)
				.UseInternalServiceProvider(serviceProvider);

			_context = new MusicCatalogContext(builder.Options);
			_context.Database.EnsureCreated();
			MusicCatalogContext.DbInitializer.Initialize(_context);

			_output.WriteLine("Database successfully initialized.  Database name: " + databaseName);
		}

		[Fact]
		public async void QueryArtistsTest()
		{
			_output.WriteLine("Starting QueryArtistsTest...");

			var artistResults = await _context.Artists.ToListAsync();

			_output.WriteLine("Results returned: " + artistResults.Count);
			_output.WriteLine("Name of first artist: " + artistResults[0].ArtistName);

			Assert.Equal(4, artistResults.Count);

		}

		public void Dispose()
		{
			_context.Database.EnsureDeleted();
		}
	}
}
