﻿using BusinessLogic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit.Abstractions;

namespace BusinessLogic.IntegrationTest
{
	public class DatabaseTests : IDisposable
	{
		MusicCatalogContext _context;
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

			var builder = new DbContextOptionsBuilder<MusicCatalogContext>();

			// build connection string depending on security model
			string connectionString = "";
			string databaseName = "musiccatalogtests_" + Guid.NewGuid();

			// Overrides from the Env Vars use the __ separator so that it works on
			// Azure DevOps Pipelines
			// and also on
			// with GigHub Pipelines

            var envVarValueIntegratedSecurity = Environment.GetEnvironmentVariable("Database__IntegratedSecurity");
            var envVarValueServer = Environment.GetEnvironmentVariable("Database__Server");
            var envVarValuePort = Environment.GetEnvironmentVariable("Database__Port");
            var envVarValueUserId = Environment.GetEnvironmentVariable("Database__UserId");
            var envVarValuePassword = Environment.GetEnvironmentVariable("Database__Password");
			
            var integratedSecurity = envVarValueIntegratedSecurity ?? config["Database:IntegratedSecurity"];
            
            if ( integratedSecurity == "true")
			{
				// using Integrated Security for local testing
				_output.WriteLine("Using local SQL Server...");
                connectionString = $"Server=(localdb)\\mssqllocaldb;Database=" + databaseName + ";Trusted_Connection=True;MultipleActiveResultSets=true";
				output.WriteLine("Connection String to remoted SQL Server: " + connectionString);
			}
			else
			{
				// using SQL authentication (username/password)  for remote database (GitHub Actions Service Container)
				_output.WriteLine("Using Remote SQL Server...");

                var server = envVarValueServer ?? config["Database:Server"];
                var port = envVarValuePort ?? config["Database:Port"];
				//var serverName = config["Database:Server"] + "," + config["Database:Port"];
				var serverName = server + "," + port;
				
                var userName = envVarValueUserId ?? config["Database:UserId"];
				var password = envVarValuePassword ?? config["Database:Password"];
				
                connectionString = "Server=" + serverName + ";Database=" + databaseName + ";User Id=" + userName + ";Password=" + password;
				output.WriteLine("Connection String to remoted SQL Server: " + connectionString);
			}

			builder.UseSqlServer(connectionString)
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
