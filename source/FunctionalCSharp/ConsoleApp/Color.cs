using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Immutable
{
	// simulate an RGB color class
	public class Color
	{

		public byte Red { get; }
		public byte Green { get; }
		public byte Blue { get; }

		public Color(byte red, byte green, byte blue)
		{
			Red = red;
			Green = green;
			Blue = blue;
			IsWhite = (Red == 255 && Green == 255 && Blue == 255);
		}

		// ToString as a Pure function

		public override string ToString()
		{
			return $"Red: {Red}, Green: {Green}, Blue: {Blue}";
		}

		public bool IsBlack()
		{
			// instance methods must be pure
			return (Red == 0 && Green == 0 && Blue == 0);

		}

		// or implement as property

		public bool IsWhite { get;  }
	}
}
