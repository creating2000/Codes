using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
		public int Calc(int a, int b = 3)	// Default value assignment.
		{
			return a + b;
		}

        static void Main(string[] args)
        {
			Program p = new Program();
			
			int r0 = p.Calc(5, 6);	// Use explicit values.
			int r1 = p.Calc(5);		// Use default for b.

			Console.WriteLine("{0}, {1}", r0, r1);
		}
	}
}