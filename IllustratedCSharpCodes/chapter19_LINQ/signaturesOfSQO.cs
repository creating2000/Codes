using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] intArray = new int[] { 3, 4, 5, 6 };
			
			// Method syntax
			var count1 = Enumerable.Count(intArray);
			var firstNum1 = Enumerable.First(intArray);
			
			// Extension syntax
			var count2 = intArray.Count();
			var firstNum2 = intArray.First();

			Console.WriteLine("Count: {0}, FirstNumber: {1}", count1, firstNum1);
			Console.WriteLine("Count: {0}, FirstNumber: {1}", count2, firstNum2);
		}
	}
}