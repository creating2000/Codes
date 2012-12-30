using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
			var groupA = new[] { 3, 4, 5, 6 };
			var groupB = new[] { 6, 7, 8, 9 };

			var someInts =	from a in groupA	// Required first from clause
							from b in groupB	// First clause of query body
							where a > 4 && b < 8
							select new { a, b, sum = a + b }; // Object of anonymous type
			foreach (var item in someInts)
			{
				Console.WriteLine(item);
			}
		}
	}
}