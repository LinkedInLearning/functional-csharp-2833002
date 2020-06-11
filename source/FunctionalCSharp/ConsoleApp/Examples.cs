using System;

namespace ConsoleApp
{
	internal class Examples
	{
		public void DoWorkWithStandardMethods()
		{
			int resultA = MakeNegative(ToFourthPower(5));
			int resultB = ToFourthPower(MakeNegative(5));
			int resultC = AddTo(ToFourthPower(MakeNegative(5)), 3);
		}

		public void DoWorkWithFunc()
		{
			Func<int, int> toFourthPower = x => x * x * x * x;
			Func<int, int> makeNegative = x => -1 * x;
			Func<int, int, int> addTo = (x, y) => x + y;

			int resultA = addTo(toFourthPower(makeNegative(5)), 3);

			// compose a new function

			var composed = makeNegative.Compose(toFourthPower);
			// var composed2 = makeNegative.Compose(toPowerFour).Compose(addTo);
			int resultB = composed(5);
		}

		#region Standard Functions
		public int ToFourthPower(int candidate)
		{
			return candidate * candidate * candidate * candidate;
		}

		public int MakeNegative(int candidate)
		{
			return candidate * -1;
		}

		public int AddTo(int candidate, int adder)
		{
			return candidate + adder;
		} 
		#endregion
	}

	public static class Extensions
	{
		public static Func<T, TReturn2> Compose<T, TReturn1, TReturn2>(this Func<TReturn1, TReturn2> func1, Func<T, TReturn1> func2)
		{
			return x => func1(func2(x));
		}
	}
}