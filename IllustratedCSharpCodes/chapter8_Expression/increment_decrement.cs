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
			int x = 5, y;
			y = x++; // result: y: 5, x: 6
			Console.WriteLine("y: {0}, x: {1}" , y, x);
			x = 5;
			y = ++x; // result: y: 6, x: 6
			Console.WriteLine("y: {0}, x: {1}" , y, x);
			x = 5;
			y = x--; // result: y: 5, x: 4
			Console.WriteLine("y: {0}, x: {1}" , y, x);
			x = 5;
			y = --x; // result: y: 4, x: 4
			Console.WriteLine("y: {0}, x: {1}" , y, x);
		}
	}
}