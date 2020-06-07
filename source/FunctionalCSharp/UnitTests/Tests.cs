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

		[TestMethod]
		public void ReturnLightenedColor()
		{

			var color1 = new ConsoleApp.Immutable.Color(0, 0, 0);
			var lightenedColor = color1.Lighten(10);
			Color expectedColor = new ConsoleApp.Immutable.Color(10,10,10);

			Assert.AreEqual(expectedColor.Red, lightenedColor.Red);
			Assert.AreEqual(expectedColor.Green, lightenedColor.Green);
			Assert.AreEqual(expectedColor.Blue, lightenedColor.Blue);
		}
		[TestMethod]
		public void ReturnLightenedColorWhenClamped()
		{

			var color1 = new ConsoleApp.Immutable.Color(200, 210, 220);
			var lightenedColor = color1.Lighten(60);
			Color expectedColor = new ConsoleApp.Immutable.Color(255, 255, 255);

			Assert.AreEqual(expectedColor.Red, lightenedColor.Red);
			Assert.AreEqual(expectedColor.Green, lightenedColor.Green);
			Assert.AreEqual(expectedColor.Blue, lightenedColor.Blue);
		}

		[TestMethod]
		public void ReturnDarkenedColor()
		{

			var color1 = new ConsoleApp.Immutable.Color(255, 255, 255);
			var darkenedColor = color1.Darken(15);
			Color expectedColor = new ConsoleApp.Immutable.Color(240, 240, 240);

			Assert.AreEqual(expectedColor.Red, darkenedColor.Red);
			Assert.AreEqual(expectedColor.Green, darkenedColor.Green);
			Assert.AreEqual(expectedColor.Blue, darkenedColor.Blue);
		}
		[TestMethod]
		public void ReturnDarkenedColorWhenClamped()
		{

			var color1 = new ConsoleApp.Immutable.Color(50, 40, 30);
			var darkenedColor = color1.Darken(70);
			Color expectedColor = new ConsoleApp.Immutable.Color(0, 0, 0);

			Assert.AreEqual(expectedColor.Red, darkenedColor.Red);
			Assert.AreEqual(expectedColor.Green, darkenedColor.Green);
			Assert.AreEqual(expectedColor.Blue, darkenedColor.Blue);
		}
	}
}
