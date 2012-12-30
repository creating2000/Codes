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
			int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };
///			var countOdd = intArray.Count(n => n % 2 == 1);
			// Lambda expression identifying the odd values.

			Func<int, bool> myDel = delegate(int x)		// Anonymous method
									{
										return x % 2 == 1;
									};
			var countOdd = intArray.Count(myDel);
			Console.WriteLine("Count of odd numbers: {0}", countOdd);
		}
	}
}