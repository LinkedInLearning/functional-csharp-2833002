using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
using ConsoleApp.Immutable;

namespace UnitTests
{
	[TestClass]
	public class ColorShould
	{

		[TestMethod]
		public void ReturnCorrectToString()
		{

			var color1 = new ConsoleApp.Immutable.Color(0, 0, 0);
			var color2 = new ConsoleApp.Immutable.Color(127, 0, 0);
			string formattedString1 = $"Red: {0}, Green: {0}, Blue: {0}";
			string formattedString2 = $"Red: {127}, Green: {0}, Blue: {0}";
			Assert.AreEqual(formattedString1, color1.ToString());

			Assert.AreEqual(formattedString2, color2.ToString());
		}

		[TestMethod]
		public void ReturnTrueWhenRGBAreZero()
		{

			var color = new ConsoleApp.Immutable.Color(0, 0, 0);

			var isBlack = color.IsBlack();
			Assert.IsTrue(isBlack);
		}

		[TestMethod]
		public void ReturnFalseWhenRGBNotZero()
		{

			var color1 = new ConsoleApp.Immutable.Color(1, 0, 0);
			var color2 = new ConsoleApp.Immutable.Color(0, 1, 0);
			var color3 = new ConsoleApp.Immutable.Color(0, 0, 1);

			
			Assert.IsFalse(color1.IsBlack());
			Assert.IsFalse(color2.IsBlack());
			Assert.IsFalse(color3.IsBlack());
		}
	}
}
