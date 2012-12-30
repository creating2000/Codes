using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	class Simple			// Non-generic class
	{
		public static void ReverseAndPrint<T> (T[] arr) // Generic method
		{
			Array.Reverse(arr);
			foreach (T item in arr)		// Use type argument T.
			{
				Console.Write("{0}, " , item.ToString());	
			}
			Console.WriteLine("");
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			// Create arrays of various types.
			var intArray = new int[] { 1, 2, 3, 4, 5 };		
			var stringArray = new string[] { "hello", "jack", "kate" };
			var doubleArray = new double[] { 2.3423, 6.7857, 10.2340};

			Simple.ReverseAndPrint<int>(intArray);	// Invoke method.
			Simple.ReverseAndPrint(intArray);		// Infer type and invoke.

			Simple.ReverseAndPrint<string>(stringArray);
			Simple.ReverseAndPrint(stringArray);

			Simple.ReverseAndPrint<double>(doubleArray);
			Simple.ReverseAndPrint(doubleArray);
		}
	}
}