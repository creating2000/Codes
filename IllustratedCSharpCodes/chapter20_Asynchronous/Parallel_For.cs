using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
        static void Main(string[] args)
        {
			// Parallel.For(0, 100, i=> Console.WriteLine("The square of {0} is {1}", i, i * i));
			
			const int maxValue = 50;
			int[] squares = new int[maxValue];
			Parallel.For(0, maxValue, i => squares[i] = i * i);
			foreach (int item in squares)
			{
				Console.WriteLine(item); // the end result is an array contains elements --- in order!
			}
		}
	}
}