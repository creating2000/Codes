using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
	class MyClass
	{
		public int Sum(int x, int y)						// Declare the method.
		{
			return x + y;									// Return the sum.
		}

		public float Average(float input1, float input2)	// Declare the method.
		{
			return (input1 + input2) / 2.0F;				// Return the average.
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			int someInt = 6;

			Console.WriteLine("Newsflash:	Sum: {0} and {1} is {2}", 5, someInt, mc.Sum(5, someInt));	// Invoke the method.

			Console.WriteLine("Newsflash:	Avg: {0} and {1} is {2}", 5, someInt, mc.Average(5, someInt));	// Invoke the method.
		}
	}
}