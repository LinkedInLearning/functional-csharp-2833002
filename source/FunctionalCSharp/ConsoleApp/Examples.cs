using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ConsoleApp
{
	class Examples
	{

		// how C# represents functions
		// Methods
		// Delegates
		// Lambda expressions

		// of these, Delegates and Lambda expressions 
		// are the most useful for functional programming
		public void DoWork()
		{
			UseHigherOrderFunction();

		}

		public void UseHigherOrderFunction()
		{
			// a  function that take a function argument 
			// or returns a function
			// is a higher order function

			var numbers = Enumerable.Range(1, 120);


			var divisibleByFive = numbers.FilterWithWhereExpression(x => x % 5 == 0);
			var divisibleBySeven = numbers.FilterWithWhereExpression(x => x % 7 == 0);

		}



		public bool IsMultipleOf(int candidate, int multiplier)

		{
			return (candidate % multiplier) == 0;
		}

	}
	public static class Extensions
	{
		// use delegates as function arguments

		public static IEnumerable<T> FilterWithWhereExpression<T>(this IEnumerable<T> items, Func<T, bool> predicate)
		{

			foreach (T item in items)
			{
				if (predicate(item))
				{
					yield return item;
				}
				{

				}
			}

		}
	}
}
