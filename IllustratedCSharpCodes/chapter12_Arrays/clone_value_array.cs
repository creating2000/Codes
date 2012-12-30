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
			// Cloning a value type array produces two independent arrays.
			int[] array = new int[3] { 1, 2, 3 };
			int[] array1 = (int[])array.Clone();
			array1[0] = 100;
			array1[1] = 200;
			array1[2] = 300;
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine("array:{0}, array1:{1}", array[i], array1[i]);
			}
		}
	}
}