using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
			int x = 10, y = 9;
			int highVal = x > y		// Condition
							? x		// Expression1
							: y;    // Expression2
			Console.WriteLine("highVal: {0}", highVal);

			Console.WriteLine("x is{0} greater than y", x > y
															? ""
															: " not", y = 11);
			Console.WriteLine("x is{0} greater than y", x > y
															? ""
															: " not");
		}
	}
}