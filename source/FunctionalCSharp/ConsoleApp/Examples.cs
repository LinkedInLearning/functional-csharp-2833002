using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
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

			var PowersOfThree = numbers.TransformWithOperation(x=>x*x*x);

			var Added = numbers.TransformWithOperation(Extensions.AddTo(3));
			var Sines = numbers.TransformWithOperation(Extensions.GetMax(20));

		}





	}
	public static class Extensions
	{
		// use delegates as function arguments

		public static IEnumerable<T> FilterWithWhereExpression<T>(this IEnumerable<T> items, Func<T, bool> predicate)
		{
			// execute this code
			// for every item in the enumerable
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

		public static IEnumerable<T1> TransformWithOperation<T1>(this IEnumerable<T1> items, Func<T1, T1> transformer)
		{
			// execute this code
			// for every item in the enumerable
			foreach (T1 item in items)
			{

				yield return transformer(item);
			} 

		}
		//  Function factory, return a function 

		public static Func<int, int> AddTo(int n) => i => i + n;
		public static Func<int, int> GetMax(int n) => i => Math.Max(i,n) ;


	}
}
