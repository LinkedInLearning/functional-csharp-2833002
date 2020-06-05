using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
	class Examples
	{
		// this is an impure function because it returns different
		// values given the same inputs.

		// also this code is not easily testable
		public DateTime GetCurrentTimeRoundedUpToCustomMinuteInterval(int interval)
		{
			var currentTime = DateTime.Now;
			var minutesSpan = TimeSpan.FromMinutes(interval).Ticks;

			if (currentTime.Ticks % minutesSpan == 0)
			{
				return currentTime;
			}
			else
			{
				return new DateTime((currentTime.Ticks / minutesSpan + 1) * minutesSpan);
			}

		}

	}
}
