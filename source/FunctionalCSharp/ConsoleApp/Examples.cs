namespace ConsoleApp
{
	internal class Examples
	{
		public void DoWorkWithPipeline()
		{
			int value = 5;

			int resultA = value.ToFourthPower().MakeNegative();
			int resultB = value.ToFourthPower().MakeNegative().AddTo(10);
		}
	}

	public static class Extensions
	{
		// input and return are the same type
		public static int ToFourthPower(this int candidate)
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
	}
}