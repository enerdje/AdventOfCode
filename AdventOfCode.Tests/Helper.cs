using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Tests
{
	public static class Helper
	{
		public static string GetPathValues(string fileName) =>
			Path.Combine(Directory.GetCurrentDirectory(), "TestData", fileName);

		public static List<int> GetListIntValues(string path) =>
			new List<int>(File.ReadLines(path).Select(int.Parse).ToList());
	}
}

//public void xd()
//{
//	var sequence = Enumerable.Range(1, 100).ToList();
//	var filter = sequence.Where(o => o > 50)
//		.Select(s => string.Concat("*", s.ToString(), "*"));
//	var firstChet = sequence.First(o => o % 2 == 0);

//	//var agr = sequence.Aggregate();

//	foreach (var item in filter)
//	{
//		Console.WriteLine(item);
//	}
//	Console.WriteLine("Первое чётное: {0}", firstChet);
//}

//public static string GetStringValue()
//{
//	return "Vladimir";
//}