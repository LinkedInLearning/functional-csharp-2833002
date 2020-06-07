using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

		public bool IsWhite { get; }

		public  Color Lighten(byte lightenBy)
		{


			var redValue = (byte)Math.Clamp(value: Red + lightenBy, min: Red, max: Byte.MaxValue);
			var greenValue = (byte)Math.Clamp(value: Green + lightenBy, min: Green, max: Byte.MaxValue);
			var blueValue = (byte)Math.Clamp(value: Blue + lightenBy, min: Blue, max: Byte.MaxValue);
			return new Color(redValue, greenValue, blueValue);
		}

		public Color Darken(byte darkenBy)
		{

			var redValue = (byte)Math.Clamp(value: Red - darkenBy, min: Byte.MinValue, max: Red);
			var greenValue = (byte)Math.Clamp(value: Green - darkenBy, min: Byte.MinValue, max: Green);
			var blueValue = (byte)Math.Clamp(value: Blue - darkenBy, min: Byte.MinValue, max: Blue);
			return new Color(redValue, greenValue, blueValue);
		}
	}
}
