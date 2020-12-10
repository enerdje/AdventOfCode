using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Days
{
	public class Day2
	{
		public List<string[]> Quest_1(List<string> list)
		{
			var splitList = list.Select(o => o.Split());

			var ranges = splitList.Select(o => o.First()
			.Split('-'))
				.Select(o => new Range(
					Int32.Parse(o.First()),
					Int32.Parse(o.Last())
					)
				).ToList();

			var charSet = splitList.Select(o => o[1][0]).ToList();
			var rowset = splitList.Select(o => o.Last()).ToList();

			CorporatePolicy[] cp = new CorporatePolicy[list.Count];

			for (int i = 0; i < list.Count; i++)
			{
				cp[i] = new CorporatePolicy(ranges[i], charSet[i], rowset[i]);
			}

			//todo Логика проверки соответсвия условию корпоративной политики паролей.

			return list.Select(o => o.Split()).ToList();
		}

		private class CorporatePolicy
		{
			public Range Range { get; set; }
			public char Symbol { get; set; }
			public string Line { get; set; }

			public CorporatePolicy(Range range, char symbol, string line)
			{
				Range = range;
				Symbol = symbol;
				Line = line;
			}

		}



		public IEnumerable<int> Quest_2(List<int> list)
		{
			return list.Where(x => list.Any(y => list.Any(z => z + y + x == 2020)));
		}
	}
}
