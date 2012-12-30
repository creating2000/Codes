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

			Func<int, bool> myDel = new Func<int, bool>(IsOdd);// Delegate object
			var countOdd = intArray.Count(myDel);// Use delegate
			
			Console.WriteLine("Count of odd numbers: {0}", countOdd);
		}

		// Method to be used by the delegate object.
		static bool IsOdd(int x)
		{
			return x % 2 == 1;	// Return true if x is odd.
		}
	}
}