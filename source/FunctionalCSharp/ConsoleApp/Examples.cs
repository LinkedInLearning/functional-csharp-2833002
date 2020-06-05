using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace ConsoleApp
{
	public class Examples
	{
	

		// avoid side effects in functions
		// A side effect is a change of system state 
		// or observable interaction with the outside world
		// that occurs during the calculation of a result.

		// a function should not 
		// 2. Mutate its input arguments
		// 
		//
	

		#region Don't mutate input arguments
		public void DoWork()
		{

			// modify to work with .NET Immutable collections

			ImmutableList<int> numbersList;
			numbersList = ImmutableList<int>.Empty;
			numbersList = ImmutableList.Create<int> ( 1, 3, 5, 7 );
			AddNumbersToList(numbersList);
			var total = TotalTheNumbers(numbersList);
			Console.WriteLine(total);
		}

		public void AddNumbersToList(ImmutableList<int>inputList)
		{
			// Pure functions should treat inputs 
			// as immutable
			// Immutable types are a core concept for FP
			inputList.Add(2);
			inputList.Add(4);
		}
		public int TotalTheNumbers(ImmutableList<int> inputList)
		{
			int total = 0;
			foreach (int number in inputList)
			{
				total += number;
			}
			return total;
		}
		#endregion

	}
}
