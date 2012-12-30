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
			int[][,] arr;			// An array of 2D arrays
			arr = new int[3][,];	// Instantiate an array of three 2D arrays.

			arr[0] = new int[,] { { 10, 20 },
								  { 100, 200 } };
			arr[1] = new int[,] { { 30, 40, 50 },
								  { 300, 400, 500}};
			arr[2] = new int[,] { { 60, 70, 80, 90 },
								  { 600, 700, 800, 900}};
			// Get length of dimension 0 of arr.
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				// Get length of dimension 0 of arr[i].
				for (int j = 0; j < arr[i].GetLength(0); j++)
				{
					// Get length of dimension 1 of arr[i].
					for (int k = 0; k < arr[i].GetLength(1); k++)
					{
						Console.WriteLine("[{0}][{1},{2}] = {3}", i, j, k, arr[i][j,k]);
					}
					Console.WriteLine("");
				}
				Console.WriteLine("");
			}

			foreach (int[,] array in arr)
			{
				Console.WriteLine("");
				foreach (int item in array)
				{
					Console.WriteLine(item);
				}
			}
		}
	}
}