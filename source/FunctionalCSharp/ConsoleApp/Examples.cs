using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
	internal class Examples
	{


		public void JoinExample()
		{
			// SelectMany is also useful for join similar lists

			var setA = Enumerable.Range(2, 3);
			var setB = Enumerable.Range(5, 3);

			var basicSelect = setA.Select(a => setB.Select(b => $"A {a}, B:{b}"));

			var basicJoin = setA.SelectMany(a => setB.Select(b => $"A:{a} B:{b}"));


			var resultsA = basicSelect.ToList();
			var resultsB = basicJoin.ToList();
		}
	}




}