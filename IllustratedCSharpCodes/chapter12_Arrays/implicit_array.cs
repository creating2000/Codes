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
			// Declare, create, and initialize an implicitly typed array.
			var arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
			// Print the values
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.WriteLine("Element [{0},{1}] is {2}", i, j, arr[i,j]);
				}
			}
		}
	}
}