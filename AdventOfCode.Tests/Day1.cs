using NUnit.Framework;
using System.Linq;

namespace AdventOfCode.Tests
{
	[TestFixture]
	public class Day1
	{
		[SetUp]
		public void Setup()
		{

		}

		[Test]
		public void Quest_1()
		{
			var firstDay = new Days.Day1();
			var list = Helper.GetListIntValues(Helper.GetPathValues("day1.txt"));

			var result = firstDay.Quest_1(list);
			var multiplicationResult = result.Aggregate((p, x) => p *= x);

			Assert.True(result.Sum() == 2020);
			Assert.True(multiplicationResult == 618144);
		}

		[Test]
		public void Quest_2()
		{
			var firstDay = new Days.Day1();
			var list = Helper.GetListIntValues(Helper.GetPathValues("day1.txt"));

			var result = firstDay.Quest_2(list);
			var multiplicationResult = result.Aggregate((p, x) => p *= x);

			Assert.True(result.Sum() == 2020);
			Assert.True(multiplicationResult == 173538720);
		}
	}
}