using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	partial class MyClass
	{
		partial void PrintSum(int x, int y); // Defining partial method

		public void Add(int x, int y)
		{
			PrintSum(x, y);
		}
	}

	partial class MyClass
	{
		partial void PrintSum(int x, int y)	// Implementing partial method
		{
			Console.WriteLine("Sum is {0}", x + y);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			mc.Add(5, 10);
		}
	}
}