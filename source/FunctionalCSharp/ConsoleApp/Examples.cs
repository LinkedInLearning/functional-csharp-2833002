using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
	class Examples
	{
		// from the Microsoft docs
		// Expressions can consist of a literal value, 
		// a method invocation, 
		// an operator and its operands, 
		// or a simple name. Simple names can be the name of a variable, type member, method parameter, namespace or type.

		public void ExamplesOfExpressions() {
			//An expression yields a value 
			// and can be used in places where a value is expected

			// variables to hold the "value"

			string stringValue;
			int intValue;

			intValue = Int32.MaxValue;

			// literals are expressions

			stringValue = "hello";
			intValue = 909;

			// variables are expressions
			string sayHello = stringValue;
			int x = intValue;

			// invocations (function calls that return a values)

			var upperCaseWord = stringValue.ToUpper();
			var concatValue = $"first number{intValue}, second number{x}";

			double calculatedValue = Math.Sqrt(Math.Abs(3) + x);

			// operators and operands

			bool isBig = x > 1000;
			string isBigString = isBig ? "Big Number" : "Small number";

		}

	

	}
}
