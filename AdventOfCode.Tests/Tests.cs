using NUnit.Framework;
using System.Linq;

namespace AdventOfCode.Tests
{
	[TestFixture]
	public class Tests 
	{

	}

	[TestFixture]
	public class Day1_Tests
	{
		[SetUp]
		public void Setup()
		{

		}

		[TestCase(2020, 618144, "day1.txt")]
		public void Quest_1(int excepted1, int excepted2, string testdata)
		{
			var firstDay = new Days.Day1.Day1();
			var list = Helper.GetListIntValues(Helper.GetPathValues(testdata));

			var actual1 = firstDay.Quest_1(list);
			var actual2 = actual1.Aggregate((p, x) => p *= x);

			Assert.AreEqual(actual1.Sum(), excepted1);
			Assert.AreEqual(actual2, excepted2);
		}

		[TestCase(2020, 173538720, "day1.txt")]
		public void Quest_2(int excepted1, int excepted2, string testdata)
		{
			var day = new Days.Day1.Day1();
			var listValues = Helper.GetListIntValues(Helper.GetPathValues(testdata));

			var actual1 = day.Quest_2(listValues);
			var actual2 = actual1.Aggregate((p, x) => p *= x);

			Assert.AreEqual(actual1.Sum(), excepted1);
			Assert.AreEqual(actual2, excepted2);
		}
	}

	[TestFixture]
	public class Day2_Tests
	{
		[SetUp]
		public void Setup()
		{

		}

		[TestCase(524, "day2.txt")]
		public void Quest_1(int excepted, string testdata)
		{
			var day = new Days.Day2.Day2();
			var listValues = Helper.GetListStringValues(Helper.GetPathValues(testdata));

			var actual = day.Quest_1(listValues);

			Assert.AreEqual(actual, excepted);
		}

		[TestCase(524, "day2.txt")]
		public void Quest_2(int excepted, string testdata)
		{
			var day = new Days.Day2.Day2();
			var listValues = Helper.GetListStringValues(Helper.GetPathValues(testdata));

			var actual = day.Quest_2(listValues);

			Assert.True(true);
		}
	}
}