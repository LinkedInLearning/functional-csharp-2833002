using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
	public class Examples
	{
		// Pure functions are similar to mathematical functions
		// they compute an output value based on their input values. 
		// the do nothing else in the code
		public long CalcExponent(long originalNumber, long exponent)
		{
			return originalNumber ^ exponent;
		}

	}
}
