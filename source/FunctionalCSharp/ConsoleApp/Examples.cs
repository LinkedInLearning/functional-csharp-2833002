using ConsoleApp.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp
{
	class Examples
	{
		public void DoWork()
		{
			Color color1 = new Color.Builder().Create(); // defaults
			Color color2 = new Color.Builder().Red(127).Create(); // red only
			Color color3 = new Color.Builder().Green(63).Alpha(255).Create(); // Green and Alpha

			var greenValue = color3.Green;

			//color2.Red = 0;

			Color lightenedColor = color3.Lighten(22);


		}

	}
}
