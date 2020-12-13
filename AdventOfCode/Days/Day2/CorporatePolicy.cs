using System;

namespace AdventOfCode.Days.Day2
{
	internal class CorporatePolicy
	{
		public Range Range { get; set; }
		public string Symbol { get; set; }
		public string Line { get; set; }

		public CorporatePolicy(Range range, string symbol, string line)
		{
			Range = range;
			Symbol = symbol;
			Line = line;
		}
	}
}
