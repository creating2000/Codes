using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
	class MyClass
	{
		public int Calc(int a, int b, int c)
		{
			return (a + b) * c;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();

			int r0 = mc.Calc(4, 3, 2);			// Positional Parameters
			int r1 = mc.Calc(4, b:3, c:2);		// Positional and Named Parameters
			int r2 = mc.Calc(4, c:2, b:3);		// Switch order
			int r3 = mc.Calc(c:2, b:3, a:4);	// All named parameters
			int r4 = mc.Calc(c:2, b:1+2, a:3+1);// Named parameter expressions

			Console.WriteLine("{0}, {1}, {2}, {3}, {4}", r0, r1, r2, r3, r4);
		}
	}
}