using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
	class Program
	{
		static void Main()
		{
			int[] numbers = { 2, 12, 5, 15 };	// Data source

			IEnumerable<int> lowNums = from n in numbers	//Define and store the query.
										where n < 10
										select n;
			foreach (var x in lowNums)					// Execute the query.
			{
				Console.WriteLine(x);
			}
		}
	}
}