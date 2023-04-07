using Microsoft.VisualStudio.TestPlatform.Utilities;
using Xunit.Abstractions;

namespace BusinessLogic.Test
{
	public class CalculationsTest
	{
		private readonly ITestOutputHelper _output;

		public CalculationsTest(ITestOutputHelper output)
		{
			this._output = output;
		}

		[Fact]
		public void CheckAdditionCalc()
		{
			_output.WriteLine("Performing CheckAdditionCalc");

			var calculations = new Calculations();
			int result = calculations.AddInts(2, 3);

			Assert.Equal(5, result);
		}

		[Fact]
		public void CheckMultiplyCalc()
		{
			_output.WriteLine("Performing CheckMultiplyCalc");

			var calculations = new Calculations();
			int result = calculations.MultiplyInts(2, 3);

			Assert.Equal(6, result);

		}
	}
}