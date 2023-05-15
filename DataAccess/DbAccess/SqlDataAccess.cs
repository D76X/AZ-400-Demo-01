using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DbAccess
{
	public interface ISqlDataAccess
	{
		Task<IEnumerable<T>> LoadData<T, U>(
			string storeProcedure,
			U parameter,
			string connectionId = DataAccessConstants.ConnectionStringNameDefault);

		Task SaveData<T>(
			string storeProcedure,
			T parameter,
			string connectionId = DataAccessConstants.ConnectionStringNameDefault);
	}

	/// <summary>
	/// Ref
	///
	/// Simple C# Data Access with Dapper and SQL - Minimal API Project Part 1
	/// https://www.youtube.com/watch?v=dwMFg6uxQ0I
	///  
	/// </summary>
	public class SqlDataAccess : ISqlDataAccess
	{
		private readonly IConfiguration _configuration;

		public SqlDataAccess(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public async Task<IEnumerable<T>> LoadData<T, U>(
			string storeProcedure,
			U parameter,
			string connectionId = DataAccessConstants.ConnectionStringNameDefault)
		{
			var connectionString = _configuration.GetConnectionString(connectionId);
			using IDbConnection connection = new SqlConnection(connectionString);

			return await connection.QueryAsync<T>(
				storeProcedure,
				parameter,
				commandType: CommandType.StoredProcedure);
		}

		public async Task SaveData<T>(
			string storeProcedure,
			T parameter,
			string connectionId = DataAccessConstants.ConnectionStringNameDefault)
		{
			var connectionString = _configuration.GetConnectionString(connectionId);
			using IDbConnection connection = new SqlConnection(connectionString);

			await connection.ExecuteAsync(
				storeProcedure,
				parameter,
				commandType: CommandType.StoredProcedure);
		}
	}
}
