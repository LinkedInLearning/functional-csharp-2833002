using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
	public class Examples
	{
		private int _counter = 0;


		// avoid side effects in functions
		// A side effect is a change of system state 
		// or observable interaction with the outside world
		// that occurs during the calculation of a result.
		
		// a function should not 
		// 1. Mutate shared state
		// 2. Mutate its input arguments
		// 3. Throw exceptions
		// 4. Perform any I/O operation
		public void UpdateByTwo()
		{
			_counter += 2;
		}
		public void UpdateByFive()
		{
			_counter += 5;
		}

		#region List as shared state


		private List<int> _numbers = new List<int> { 1, 3, 5, 7 };

		public void AddNumbersToList()
		{
			_numbers.Add(2);
			_numbers.Add(4);
		}

		public int TotalTheNumbers()
		{
			int total =0;
			foreach (int number in _numbers)
			{
				total += number;
			}
			return total;
		}
		#endregion

	
}
