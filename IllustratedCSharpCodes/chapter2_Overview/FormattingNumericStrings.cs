using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("The value: {0}", 500);
			Console.WriteLine("The value: {0:C}", 500);// Format as currency;

			int myInt = 500;
			Console.WriteLine("|{0, 10}|", myInt); // positive: right-aligned
			Console.WriteLine("|{0, -10}|", myInt);// negative: left-aligned

			double myDouble = 12.345678;
			Console.WriteLine("{0,-10} -- Default, same as General", myDouble);
			Console.WriteLine("{0,-10:G} -- General", myDouble);
			Console.WriteLine("{0,-10:F4} -- Fixed Point, 4 dec places", myDouble);
			Console.WriteLine("{0,-10:C} -- Currency", myDouble);
			Console.WriteLine("{0,-10:E3} -- Sci. Notation, 3 dec places", myDouble);
			Console.WriteLine("{0,-10:x} -- Hexadecimal integer", 1194719);
		}
	}
}