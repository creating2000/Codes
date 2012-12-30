using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structs
{
	struct Simple
	{
		public int X;
		public int Y;

		public Simple(int a, int b) // explicit constructor doesn't override implicit constructor
		{
			X = a;
			Y = b;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Simple s1 = new Simple();
			Simple s2 = new Simple(10, 10);
			Console.WriteLine("{0}, {1}", s1.X, s1.Y); // Call implicit constructor
			Console.WriteLine("{0}, {1}", s2.X, s2.Y); // Call explicit constructor
		}
	}
}