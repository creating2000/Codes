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
			int[,] arr1 = { { 10, 11 }, { 12, 13 }};
			int total = 0;

			foreach (var element in arr1)
			{
				total += element;
				Console.WriteLine("Element: {0}, Current Total: {1}", element, total);
			}
		}
	}
}