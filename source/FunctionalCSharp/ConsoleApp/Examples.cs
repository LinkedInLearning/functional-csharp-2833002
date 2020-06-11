using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp
{
	class Examples
	{




		public void UseEnumerablePipeline()
		{

			// this is similar to the LINQ versions

			var numbers = Enumerable.Range(1, 120);
		
			// evaluated from right to left

			var resultA = numbers.WhereAsPipeline(x => x % 5 == 0).ToList();
			var resultB = numbers.WhereAsPipeline(x => x % 12 ==0).TransformAsPipeline(x => x * 10).ToList();

			var resultC = resultB.SkipByAsPipeline(30).ToList();
		}



	}

	public static class Extensions
	{

		public static IEnumerable<T> WhereAsPipeline<T>(this IEnumerable<T> source, Func<T, bool> predicate)
		{
			// execute this code
			// for every item in the enumerable
			foreach (T item in source)
			{
				if (predicate(item))
				{
					yield return item;
				}
				
			}


		}

		public static IEnumerable<T> TransformAsPipeline<T>(this IEnumerable<T> source, Func<T, T> transformer)
		{
			// execute this code
			// for every item in the enumerable
			foreach (T item in source)
			{

				yield return transformer(item);
			}

		}
		public static IEnumerable<T> SkipByAsPipeline<T>(this IEnumerable<T> source, int numberToSkip)
		{
			using (IEnumerator<T> e = source.GetEnumerator())
			{
				while (numberToSkip > 0 && e.MoveNext()) numberToSkip--;
				if (numberToSkip <= 0)
				{
					while (e.MoveNext()) yield return e.Current;
				}
			}

		}

		public static T PerformOperation<T>(this T value, Func<T, T> performer) where T : struct
		{

			return performer(value);
		}
	}
}
