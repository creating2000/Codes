using System;
using System.Collections.Generic;
using System.Collections; // for IEnumerator
using System.Linq;
using System.Text;

namespace Enumerators
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] intArr = { 1, 3, 4, 5, 6, 7, 8 };		// Create an array.
			IEnumerator ie = intArr.GetEnumerator();	// Get and store the enumerator.
			while (ie.MoveNext())  // Move to the next Position.
			{
				int i = (int)ie.Current;   // Get the current item.
				Console.WriteLine(i);		// Write it out.
			}
		}
	}
}