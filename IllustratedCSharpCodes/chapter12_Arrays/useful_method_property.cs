using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
		public static void PrintArray(int[] a)
		{
			foreach (int item in a)
			{
				Console.Write(item);
				Console.Write("\t");
			}
			Console.WriteLine("");
		}

        static void Main(string[] args)
        {
			int[] arr = new int[5] { 15, 20, 5, 25, 10 };
			PrintArray(arr);

			Array.Sort(arr);
			PrintArray(arr);

			Array.Reverse(arr);
			PrintArray(arr);

			Console.WriteLine("Rank = {0}, Length = {1}", arr.Rank, arr.Length);
			Console.WriteLine("GetLength(0) = {0}", arr.GetLength(0));
			Console.WriteLine("GetType() = {0}", arr.GetType());
		}
	}
}