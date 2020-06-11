using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp
{
	class Examples
	{



		public void DoWorkWithPipeine()
		{


			int value = 5;
			int resultA = value.ToPowerFour().MakeNegative();
			int resultB = value.ToPowerFour().MakeNegative().AddTo(10);

			
		}


	}

	public static class Extensions
	{
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
		
	}
}
