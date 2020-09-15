using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class APureFunction_Should
	{
		[TestMethod]
		public void ReturnSameResults_WhenSameInputs()
		{
			// arrange
			var examples = new Examples();
			decimal salesAmount = 50M;
			decimal discount = .3M;
			// act
			var result1 = examples.CalcDiscount(salesAmount, discount);
			var result2 = examples.CalcDiscount(salesAmount, discount);

			// assert
			Assert.AreEqual((salesAmount * (1 - discount)) , result1);
			Assert.AreEqual(result1, result2);
		}
	}
}
