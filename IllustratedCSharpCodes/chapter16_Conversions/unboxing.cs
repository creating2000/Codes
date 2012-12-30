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
			int i = 10;
			// Box i and assign its reference to oi.
			object oi = i;
			// Unbox oi and assign its value to j.
			int j = (int)oi;
			Console.WriteLine("i: {0}, oi: {1}, j:{2}", i, oi, j);
		}
	}
}