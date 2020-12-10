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

		public static List<string> GetListStringValues(string path) =>
			new List<string>(File.ReadLines(path).ToList());
	}
}