using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Days
{
	public class Day1
	{
		public IEnumerable<int> Quest_1(List<int> list)
		{
			return list.Where(x => list.Any(o => x + o == 2020));
		}

		public IEnumerable<int> Quest_2(List<int> list)
		{
			return list.Where(x => list.Any(y => list.Any(z => z + y + x == 2020)));


			//for (int i = 0; i < list.Count; i++)
			//	for (int j = 0; j < list.Count; j++)
			//		for (int k = 0; k < list.Count; k++)
			//			if (list[i] + list[j] + list[k] == 2020)
			//				Console.WriteLine(list[i] * list[j] * list[k]);
		}
	}
}
