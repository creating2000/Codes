using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
	class MyClass
	{
		public int Calc(int a = 2, int b = 3, int c = 4)
		{
			return (a + b) * c;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();

			int r0 = mc.Calc(5, 6, 7);	// Use all explicit values.
			int r1 = mc.Calc(5, 6);		// Use default for c
			int r2 = mc.Calc(5);		// Use default for b, c
			int r3 = mc.Calc();			// Use all defaults

			Console.WriteLine("{0},{1},{2},{3}", r0, r1, r2, r3);
		}
	}
}