using System;
using System.Linq;

namespace ConsoleApp
{
	internal class Examples
	{
		public void FilterSimple()
		{
			// functional Filter == LINQ Where
			// return a subset of the list based
			// on predicate function

			var numbers = Enumerable.Range(1, 200);

			var queryA = numbers.Where(x => x < 20).Select(x => x);

			var queryB = from n in numbers
									 where n < 20 || n > 180
									 select n;

			var resultsA = queryA.ToList();
			var resultsB = queryB.ToList();
		}

		public void FilterForPrimeNumbers()
		{
			// this predicate determines if
			// a number is prime

			Func<int, bool> isPrime = p => Enumerable.Range(2, (int)Math.Sqrt(p) - 1)
																		.All(divisor => p % divisor != 0);

			var primes =
				Enumerable.Range(2, 1000 * 1000)
				.Where(isPrime);

			var resultsA = primes.ToList();
		}
	}
}
}