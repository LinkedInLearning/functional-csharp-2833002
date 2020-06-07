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

			// instantiate the Immutable color class

			var myColor1 = new Immutable.Color(red: 127, green: 0, blue: 255);
			Console.WriteLine(myColor1.ToString());
			var isBlack = myColor1.IsBlack();
		}

	}
}
