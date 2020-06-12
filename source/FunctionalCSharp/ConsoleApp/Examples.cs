using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
	internal class Examples
	{
		public void FlattenListProperty()
		{
			// functional bind (in Haskell)
			// called flatMap (in Scala)
			// and is concept is called flattening in C#
			// LINQ SelectMany or ContinueWith

			// flattens a multi-dimensional set into a single set

			// or another way to say
			// SelectMany select values from a nested collection

			var brandA = new Brand { Name = "Fancy-Shoes", Colors = new List<string> { "Red", "Orange" } };
			var brandB = new Brand { Name = "Lux-Cars", Colors = new List<string> { "Gold", "Silver" } };
			var brandC = new Brand { Name = "Wow-Electronics", Colors = new List<string> { "Black", "Blue", "Purple" } };
			List<Brand> brands = new List<Brand>();
			brands.Add(brandA);
			brands.Add(brandB);
			brands.Add(brandC);

		
			// this does not produce the results we want
			var resultA = brands.Select(x => x.Colors).ToList(); 
			//var resultB = brands.SelectMany(x => x.Colors).ToList();
		}

		public void SelectManyExample()
		{
			var setA = Enumerable.Range(2, 3);
			var setB = Enumerable.Range(5, 3);

			var basicSelect = setA.Select(a => $"value {a}");
		
			var basicJoin = setA.SelectMany(a => setB.Select(b => $"A:{a} B:{b}"));

		
			var resultsA = basicSelect.ToList();
			var resultsB = basicJoin.ToList();
		}
	}

	public static class Extensions
	{
		// signature looks like this
		public static IEnumerable<B> SelectMany_Example<A, B>(this IEnumerable<A> first, Func<A, IEnumerable<B>> selector)
		{
			return null;
		}
	}

	// this in not immutable yet

	public class Brand
	{
		public string Name { get; set; }
		public List<string> Colors { get; set; }
	}
}