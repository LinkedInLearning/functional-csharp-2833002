using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp
{
	public class Examples
	{
		// Pure functions are similar to mathematical functions
		// they compute an output value based on their input values. 
		// the do nothing else in the code
		public decimal CalcDiscount(decimal amount, decimal discountRate)
		{
			return amount * (1 - discountRate);
		}

	}
}
