using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
public	class Examples
	{
		// Fix impure function by refactoring to only work
		// with parameters passed into the function 

		// also this code is not easily testable
		public DateTime GetCurrentTimeRoundedUpToCustomMinuteInterval(int interval, 
																																	DateTime startTime)
		{
			// 	var currentTime = DateTime.Now;
			var minutesSpan = TimeSpan.FromMinutes(interval).Ticks;

			if (startTime.Ticks % minutesSpan == 0)
			{
				return startTime;
			}
			else
			{
				return new DateTime((startTime.Ticks / minutesSpan + 1) * minutesSpan);
			}
			
		}

	}
}
