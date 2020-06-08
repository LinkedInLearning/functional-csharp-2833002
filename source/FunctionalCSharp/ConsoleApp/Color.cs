using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Immutable
{
	// simulate an RGB color class
	public sealed class Color
	{

		// this style of automatic property is obsolete
		// for Immutable types
		public int Orange { get; private set; }

		// this is better, but slightly more verbose

		// this backing field must be set in the constructor
		// as there is no setter 
		private readonly int _purple;

		public int Purple
		{
			get { return _purple; }

		}


		// In C# 6 (released in 2015) you can create
		// read-only automatically-implemented properties:
		// this property can only be assigned in a constructor

		public byte Red { get; }
		public byte Green { get; }
		public byte Blue { get; }

		public Color(byte red, byte green, byte blue)
		{
			Red = red;
			Green = green;
			Blue = blue;
		}
		public Color(byte red)
		{
			Red = red;
			Green = 0;
			Blue = 0;
		}

	}
}
