using NUnit.Framework;
using System.Linq;

namespace AdventOfCode.Tests
{
	public class Tests { }

	[TestFixture]
	public class Day1_Tests
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
			var listValues = Helper.GetListIntValues(Helper.GetPathValues("day1.txt"));

			var result = firstDay.Quest_2(listValues);
			var multiplicationResult = result.Aggregate((p, x) => p *= x);

			Assert.True(result.Sum() == 2020);
			Assert.True(multiplicationResult == 173538720);
		}
	}

	[TestFixture]
	public class Day2_Tests
	{
		[SetUp]
		public void Setup()
		{

		}

		[Test]
		public void Quest_1()
		{

		}

		[Test]
		public void Quest_2()
		{

		}
	}
}