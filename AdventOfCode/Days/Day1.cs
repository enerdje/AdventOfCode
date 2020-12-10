using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Days
{
	public class Day1
	{
		public IEnumerable<int> Quest_1(IReadOnlyList<int> list)
		{
			return list.Where(x => list.Any(o => x + o == 2020));
		}

		public IEnumerable<int> Quest_2(IReadOnlyList<int> list)
		{
			return list.Where(x => list.Any(y => list.Any(z => z + y + x == 2020)));
		}
	}
}
