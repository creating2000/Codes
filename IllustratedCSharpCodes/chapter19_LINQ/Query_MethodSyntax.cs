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
			int[] numbers = { 2, 5, 28, 31, 17, 16, 42 };
			
			var numsQuery = from n in numbers				// Query syntax	
							where n < 20
							select n;

			var numsMethod = numbers.Where(x => x < 20);	// Method syntax

			int numsCount = (from n in numbers				//Combined syntax
							where n < 20
							select n).Count();

			foreach (var x in numsQuery)
			{
				Console.Write("{0},", x);
			}
			Console.WriteLine();

			foreach (var x in numsMethod)
			{
				Console.Write("{0},", x);
			}
			Console.WriteLine();

			Console.WriteLine(numsCount);

		}
	}
}