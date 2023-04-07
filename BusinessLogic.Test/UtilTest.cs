using Common;
using Xunit.Abstractions;

namespace BusinessLogic.Test
{
	public class UtilsTest
	{
		private readonly ITestOutputHelper _output;

		public UtilsTest(ITestOutputHelper output)
		{
			this._output = output;
		}

		[Fact]
		public void ReplaceDatabaseToken()
		{
			_output.WriteLine(nameof(ReplaceDatabaseToken));
			
			// arrange
			var connectionStringWithTokenToBeReplaced = "Server=localhost,1433; Database={databaseName}; User Id=SA; Password=P@ssword1$; TrustServerCertificate=True;MultiSubnetFailover=True";
			var replacement = @"MyDb";
			var expected = $"Server=localhost,1433; Database={replacement}; User Id=SA; Password=P@ssword1$; TrustServerCertificate=True;MultiSubnetFailover=True";
			
			// act
			var result = 
				connectionStringWithTokenToBeReplaced
					.Replace(
						TestConstants.DatabaseNameToken,
						replacement);

			Assert.Equal(expected, result);
		}
	}
}
