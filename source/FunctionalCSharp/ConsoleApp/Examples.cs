using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
	class Examples
	{
		public void ExamplesOfExpressions() {
			//An expression yields a value 
			// and can be used in places where a value is expected

			// variables to hold the "value"

			string stringValue;
			int intValue;

			// literals are expressions

			stringValue = "hello";
			intValue = 909;

			// variables are expression
			string hello = stringValue;
			int x = intValue;

			// invocations (function calls that return a values)

			var upperCaseWord = stringValue.ToUpper();
			var concatValue = $"first number{intValue}, second number{x}";

			double calculatedValue = Math.Sqrt(Math.Abs(3) + x);

			// operators and operands

			bool isBig = x > 1000;
			string isBigString = isBig ? "Big Number" : "Small number"
;

		}

		// Expressions include anything that produces a value, such as these:

	}
}
