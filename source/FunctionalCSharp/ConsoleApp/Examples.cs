using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleApp
{
	class Examples
	{
		public void DoWork()
		{


			var currentProduct = new Product(productName: "Microphone", retailPrice: 200M);
			var salePriceA = GetProductPrice(product: currentProduct, quantity: 12, isPremiumCustomer: true);

			var salePriceB = GetProductPriceByExpression(product: currentProduct, quantity: 12, isPremiumCustomer: true);
		}

		#region If Statements
		public decimal GetProductPrice(Product product, int quantity, bool isPremiumCustomer)
		{
			// statement version

			// note that the purpose of the if statement is to mutate the value of the discountAmount variable
			// note that the discountAmount variable is declared outside the statements
			decimal discountAmount = 0;
			if (quantity > 10)
			{
				discountAmount += .15M;
			}
			if (isPremiumCustomer)
			{
				discountAmount += .05M;
			}
			return product.RetailPrice * (1 - discountAmount);


		}
		public decimal GetProductPriceByExpression(Product product, int quantity, bool isPremiumCustomer)
		{
			// expression version
			// In this version there is no mutation of variable, and also the code is more compact.

			//	The conditional operator ?:, also known as the ternary conditional operator, 
			// evaluates a Boolean expression and returns the result of one of the two expressions, depending on whether the Boolean expression evaluates to true or false.

			decimal discountAmount = (quantity > 10 ? .15M : 0) + (isPremiumCustomer ? .05M : 0);

			return product.RetailPrice * (1 - discountAmount);

			// expressions are more composable

		}
		#endregion
		#region Switch Statements

		public string GetColorHex(StandardColors colors)
		{
			string hexString = string.Empty;
			switch (colors)
			{
				case StandardColors.Red:
					hexString = "FF0000";
					break;
				case StandardColors.Orange:
					hexString = "FFA500";
					break;
				case StandardColors.Yellow:
					hexString = "FFFF00";
					break;
				case StandardColors.Green:
					hexString = "008000";
					break;
				case StandardColors.Blue:
					hexString = "0000FF";
					break;
				case StandardColors.Black:
					hexString = "FFFFFF";
					break;
				case StandardColors.White:
					hexString = "000000";
					break;
				default:
					hexString = "000000";
					break;
			}
			return hexString;
		}

		public string GetColorHexByExpression(StandardColors colors)
		{
			string hexString = colors switch
			{
				StandardColors.Red => "FF0000",
				StandardColors.Orange => "FFA500",
				StandardColors.Yellow => "FFFF00",
				StandardColors.Green => "008000",
				StandardColors.Blue => "0000FF",
				StandardColors.Black => "FFFFFF",
				StandardColors.White => "000000",
				_ => "000000",
			};
			return hexString;
		}

		#endregion
		#region Types
		public enum StandardColors
		{
			Red,
			Orange,
			Yellow,
			Green,
			Blue,
			Indigo,
			Violet,
			Black,
			White
		}
	}
	public class Product
	{
		public decimal RetailPrice { get; }
		public string ProductName { get; }

		public Product(string productName, decimal retailPrice)
		{
			ProductName = productName;
			RetailPrice = retailPrice;

		}
			#endregion
		}
	}
