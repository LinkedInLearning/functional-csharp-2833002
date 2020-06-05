using System;
using System.Collections.Generic;
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
	

		#region List as shared state


		private List<int> _numbers = new List<int> { 1, 3, 5, 7 };

		public void AddNumbersToListOld()
		{
			_numbers.Add(2);
			_numbers.Add(4);
		}

		public int TotalTheNumbersOld()
		{
			int total = 0;
			foreach (int number in _numbers)
			{
				total += number;
			}
			return total;
		}
		#endregion

		#region Don't mutate input arguments
		public void DoWork()
		{ 

			
			var numbersList = new List<int> { 1, 3, 5, 7 };
			AddNumbersToList(numbersList);
			var total = TotalTheNumbers(numbersList);
			Console.WriteLine(total);
		}

		public void AddNumbersToList(List<int>inputList)
		{
			// Pure functions should treat inputs 
			// as immutable
			// Immutable types are a core concept for FP
			inputList.Add(2);
			inputList.Add(4);
		}
		public int TotalTheNumbers(List<int> inputList)
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
