using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace ConsoleApp
{
	class Examples
	{


		public void SelectWithNoTransform()
		{
			// functional Map == LINQ Select
			// transform each item in the list

			var numbers = Enumerable.Range(1, 50);

			// use extension methods
			var queryA = numbers.Select(x => x);// perform no actions

			// use query expression
			var queryB = from n in numbers
									 select n;

			// run the query
			List<int> resultsA = new List<int>();
			foreach (int number in queryA)
			{
				// this is not the functional way to
				// populate the list
				resultsA.Add(number);
			}

			// the functional way
			var resultsB = queryB.ToList();

		}

		public void SelectWithNumberTransform()
		{
			// functional Map == LINQ Select
			// perform an action

			var numbers = Enumerable.Range(1, 50);

			var queryA = numbers.Select(x => x * 10);

			var queryB = from n in numbers
									 select n * 10;


			var resultsA = queryA.ToList();
			var resultsB = queryB.ToList();

		}

		public void SelectProjectToAnotherType()
		{
			// functional Map == LINQ Select
			// perform an action

			var xValues = Enumerable.Range(1, 20);
			var yValues = Enumerable.Range(100, 20);

			var queryA = xValues.Select(x => new RayPoint(x, 0));

			var queryB = from n in yValues
									 select new RayPoint(0, n);


			var resultsA = queryA.ToList();
			var resultsB = queryB.ToList();

		}
	}

	public class RayPoint
	{
		public int X { get; }
		public int Y { get; }
		public RayPoint(int x, int y)
		{
			X = x;
			Y = y;
		}
	}
}
