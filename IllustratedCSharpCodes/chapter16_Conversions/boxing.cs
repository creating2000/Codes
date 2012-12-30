using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
			int i = 10;		// Create and initialize value type.
			// Box i and assign its reference to oi.
			object oi = i;	// Create and initialize reference type.
			Console.WriteLine("i: {0}, oi: {1}", i, oi);

			i = 15;
			oi = 20;
			Console.WriteLine("i: {0}, oi: {1}", i, oi);
		}
	}
}