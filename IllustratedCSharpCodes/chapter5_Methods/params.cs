using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
	class MyClass
	{
		public void ListInts( params int[] inVals)
		{
			if (inVals != null && inVals.Length != 0)
			{
				for (int i = 0; i < inVals.Length; i++)		// Process the array.
				{
					inVals[i] = inVals[i] * 10;
					Console.WriteLine(inVals[i]);			// Display new value.
				}
			}
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			int[] myArr = new int[] { 5, 6, 7 };	// Create and initialize array.
///			int first = 5, second = 6, third = 7;		// Declare three ints.
			MyClass mc = new MyClass();
///			mc.ListInts( first, second, third);			// Call the method.
///			Console.WriteLine("{0}, {1}, {2}", first, second, third);
			mc.ListInts(myArr);						// Call method to print the values.
			foreach (int x in myArr)
			{
				Console.WriteLine("{0}", x);		// Print out each element.
			}
			
		}
	}
}