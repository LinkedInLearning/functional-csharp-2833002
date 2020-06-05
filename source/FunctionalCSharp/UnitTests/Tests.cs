using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
using System;

namespace UnitTests
{
	[TestClass]
	public class CustomIntervalShould
	{
		[TestMethod]
		public void ReturnTheTimePlus5Interval()
		{

			var examples = new Examples();

			var testDateTime = new DateTime(year:2021, month: 8, day: 21, 
																hour: 11, minute: 59, second: 12);
			var expectedResult = new DateTime(year: 2021, month: 8, day: 21,
																hour: 12, minute: 00, second: 00);

			var createdDateTime = examples.GetCurrentTimeRoundedUpToCustomMinuteInterval(interval: 5, startTime: testDateTime);

			Assert.AreEqual(expectedResult, createdDateTime);
		}
		[TestMethod]
		public void ReturnTheTimePlus3Interval()
		{

			var examples = new Examples();

			var testDateTime = new DateTime(year: 2021, month: 8, day: 21,
																hour: 9, minute: 13, second: 12);
			var expectedResult = new DateTime(year: 2021, month: 8, day: 21,
																hour: 9, minute: 15, second: 00);

			var createdDateTime = examples.GetCurrentTimeRoundedUpToCustomMinuteInterval(interval: 4, startTime: testDateTime);

			Assert.AreEqual(expectedResult, createdDateTime);
		}
	}
}
