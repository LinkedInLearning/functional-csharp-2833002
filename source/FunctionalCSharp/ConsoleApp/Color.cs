using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp.Immutable
{
	// simulate an RGB color class
	public sealed class Color
	{
		// use a builder to create new color
		// flexible, don't have to write multiple constructor
		// when using optional arguments
		// with four optional, might need 15 constructors
		public byte Red { get; }
		public byte Green { get; }
		public byte Blue { get; }
		public byte Alpha { get; }

		public Color Lighten(byte lightenBy)
		{

			var redValue = (byte)Math.Clamp(value: Red + lightenBy, min: Red, max: Byte.MaxValue);
			var greenValue = (byte)Math.Clamp(value: Green + lightenBy, min: Green, max: Byte.MaxValue);
			var blueValue = (byte)Math.Clamp(value: Blue + lightenBy, min: Blue, max: Byte.MaxValue);
			var newColor   = new Color.Builder().Red(redValue).Green(greenValue).Blue(blueValue).Alpha(this.Alpha).Create(); 
			return newColor;
		}

		//public Color(byte red, byte green, byte blue)
		//{
		//	Red = red;
		//	Green = green;
		//	Blue = blue;

		//}
		private Color(byte red, byte green, byte blue, byte alpha)
		{
			
			Red = red;
			Green = green;
			Blue = blue;
			Alpha = alpha;
		}


		public class Builder
		{
			private byte _red;
			private byte _green;
			private byte _blue;
			private byte _alpha;


			public Builder Red(byte red)
			{
				_red = red;
				return this;
			}
			public Builder Blue(byte blue)
			{
				_blue = blue;
				return this;
			}

			public Builder Green(byte green)
			{
				_green = green;
				return this;
			}
			public Builder Alpha(byte alpha)
			{
				_alpha = alpha;
				return this;
			}

			public Color Create()
			{
				return new Color(_red, _green, _blue, _alpha);
			}
		}
	}
}
