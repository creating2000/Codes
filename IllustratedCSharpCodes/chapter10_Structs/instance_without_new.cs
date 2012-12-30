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
	}

    	class Program
    	{
       	 	static void Main(string[] args)
        	{
			Simple s1, s2; // No constructor calls
			Console.WriteLine("{0}, {1}", s1.X, s1.Y); // Compile error

			s2.X = 10;
			s2.Y = 100;
			Console.WriteLine("{0}, {1}", s2.X, s2.Y); // OK
		}
	}
}
