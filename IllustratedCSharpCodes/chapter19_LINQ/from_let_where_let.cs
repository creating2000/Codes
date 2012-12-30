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

			var someInts =	from a in groupA

							from b in groupB
							let sum = a + b		// Store result in new variable
							where sum == 12

							select new { a, b, sum };

			foreach (var item in someInts)
			{
				Console.WriteLine(item);
			}
		}
	}
}