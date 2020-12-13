using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Days.Day2
{
	public class Day2
	{
		public int Quest_1(List<string> dataList)
		{
			var splitList = dataList.Select(o => o.Split()).ToList();

			var corporatePolicy =
				from item in dataList
				let i = dataList.IndexOf(item)
				select new CorporatePolicy(GetRange(splitList[i]), GetSymbol(splitList[i]), GetLine(splitList[i]));

			var results = from o in corporatePolicy
						  let i = Occurrences(o.Line, o.Symbol)
						  where Contains(o.Range, i)
						  select o;

			return results.Count();
		}

		public int Quest_2(List<string> dataList)
		{
			var splitList = dataList.Select(o => o.Split()).ToList();

			var corporatePolicy =
				from item in dataList
				let i = dataList.IndexOf(item)
				select new CorporatePolicy(GetRange(splitList[i]), GetSymbol(splitList[i]), GetLine(splitList[i]));

			var hgfhgfhf = corporatePolicy.Where(o => o.Symbol == o.Line[o.Range.Start.Value].ToString());

			//todo: Доделать логику решения второй части задачи.

			return 1;
		}

		private static Range GetRange(string[] values)
		{
			var range = values.First().Split('-').Select(int.Parse);
			return range.First()..range.Last();
		}

		private static string GetLine(string[] values) => values.Last();
		private static string GetSymbol(string[] values) => values[1][0].ToString();
		private static int Occurrences(string line, string symbol) => new Regex(symbol).Matches(line).Count;
		private static bool Contains(Range range, int value) => range.Start.Value <= value && value <= range.End.Value;
	}
}
