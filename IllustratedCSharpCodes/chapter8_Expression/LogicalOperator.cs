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
			const byte x = 12, y = 10;
			sbyte a;

			a = x & y;
			Console.WriteLine(a);
			a = x | y;
			Console.WriteLine(a);
			a = x ^ y;
			Console.WriteLine(a);
			a = ~x;
			Console.WriteLine(a);
		}
	}
}