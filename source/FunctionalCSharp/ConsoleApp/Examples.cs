using System;

namespace ConsoleApp
{
	internal class Examples
	{
		public void DoWorkWithPipeine()
		{

			int value = 5;
			int resultA = value.ToPowerFour().MakeNegative();
			int resultB = value.ToPowerFour().MakeNegative().AddTo(10);
		}

		public void DoWorkWithStandardLambda()
		{
			Func<int, int> toPowerFour = x => x * x * x * x;
			Func<int, int> makeNegative = x => -1 * x;

			int value = 5;
			int resultA = value.PerformOperation(toPowerFour).PerformOperation(makeNegative).PerformOperation(x => x + 3);
			double doubleVal = 7.5;
			double resultB = doubleVal.PerformOperation(x => Math.Sin(x)).PerformOperation(x => x * Math.PI);
		}
	}

	public static class Extensions
	{
		#region Previous examples

		// input and return are the same type
		public static int ToPowerFour(this int candidate)
		{
			return candidate * candidate * candidate * candidate;
		}

		public static int MakeNegative(this int candidate)
		{
			return candidate * -1;
		}

		public static int AddTo(this int candidate, int adder)
		{
			return candidate + adder;
		}

		#endregion Previous examples

		public static T PerformOperation<T>(this T value, Func<T, T> performer) where T : struct
		{
			return performer(value);
		}
	}
}