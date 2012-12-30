using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
			int x = 0;
			do
				Console.WriteLine("x is {0}", x++);
			while (x < 3);	// A semicolon is required.
		}
	}
}