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
			var numbers = new int[] { 2, 4, 6, 8, 10 };

			int howMany = (from n in numbers
							where n < 7
							select n).Count();
			Console.WriteLine("Count: {0}", howMany);

		}
	}
}