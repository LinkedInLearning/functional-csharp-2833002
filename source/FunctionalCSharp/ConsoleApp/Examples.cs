using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp
{
	class Examples
	{
		public void DoWork()
		{
			// Immutable types internal state is not changeable after creation.

			DateTime dt1, dt2;

			// set some properties in the constructor
			dt1 = new DateTime(year: 2025, month: 10, day: 26);
			

			// all properties are read-only after initialization 
			// or think of them at write-once

			int day = dt1.Day; // we can read this value

			// dt1.Day = 27;  // we cannot change it via the property

			// But what about when we do need to change the instance
			// For example add 3 days to the existing date.
			dt2 = new DateTime(year: 2025, month: 10, day: dt1.Day + 3);
			// or use the existing variable, 
			dt1 = new DateTime(year: 2025, month: 10, day: dt1.Day + 3);



		}

	}
}
