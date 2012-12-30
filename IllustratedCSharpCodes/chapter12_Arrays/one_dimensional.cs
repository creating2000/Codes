using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] myIntArray = new int[4];

			for (int i = 0; i < 4; i++)
			{
				myIntArray[i] = i * 10;	// Set the values.
			}

			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine("Value of element {0} is {1}", i, myIntArray[i]);
			}
		}
	}
}