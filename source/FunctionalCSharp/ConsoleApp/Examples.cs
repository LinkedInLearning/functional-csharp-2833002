using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
	internal class Examples
	{
		public void AggregateExample()
		{
			// function fold (or reduce)
			// fold applies a function to each item in the list
			// it takes a list, and returns a single result (not a list)
			// It is an accumulative function
			// for example, SUM totals the 1st and 2nd item 
			// then totals that result with the 3rd item and so on...
			// 
			// LINQ (Aggregate, Sum, Average)
			// LINQ (Max, Min, Count)

			ImmutableList<int> setA = ImmutableList.Create(5, 4, 1, 3, 9, 8, 6, 7, 2, 12, 24);
			ImmutableList<int> setB = ImmutableList.Create(Enumerable.Range(1, 40).Where(x => x % 5 == 0).ToArray());

			// predefined aggregates
			var total = setA.Sum();
			var count = setB.Count();

			var highestNumber = setB.Max();


			// custom aggregate

			var multipleOf = setA.Aggregate((first, second) => first * second);

			// set the initial seed (accumulator value)

			var anotherMultiple = setA.Aggregate(100, (first, second) => first * second);
		}

		public void AggregateRobots()
		{
			
			var robot1 = new Robot(name: "Robot1", batteryLevel: 60);
			var robot2 = new Robot(name: "Robot2", batteryLevel: 45);
			var robot3 = new Robot(name: "Robot3", batteryLevel: 95);
			var robot4 = new Robot(name: "Robot4", batteryLevel: 27);

			ImmutableList<Robot> robots = ImmutableList.Create(new Robot[] { robot1, robot2 , robot3, robot4});

			var lowBattery = robots.Min(x => x.BatteryLevel);
	
		}

	}




	public class Robot
	{
		public string Name { get; }
		public int BatteryLevel { get; }
		public Robot(string name, int batteryLevel)
		{
			Name = name;
			BatteryLevel = batteryLevel;
		}
	}
}