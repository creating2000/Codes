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
			// The body of this for loop is executed for three times.
			for ( int i = 0; i < 3; i++)
			{
				Console.WriteLine("Inside loop. i: {0}", i);
			}
			Console.WriteLine("Out of loop");
		}
	}
}