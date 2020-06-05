using System;
using System.Threading;

namespace ConsoleApp
{
	class Program
	{

		static void Main(string[] args)
		{

			Timer t = new Timer(TimerCallback, null, 0, 1000);
			Console.ReadLine();
			
		}
			private static void TimerCallback(Object o)
			{
			var examples = new Examples();
			Console.Clear();
			Console.WriteLine(DateTime.Now);
			var result = examples.GetCurrentTimeRoundedUpToCustomMinuteInterval(12, DateTime.Now);
			Console.WriteLine(result);
		}
		
	}
}
