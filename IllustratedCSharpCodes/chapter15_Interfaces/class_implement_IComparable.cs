using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	class MyClass : IComparable			// Class implements interface.
	{
		public int TheValue;
		public int CompareTo(object obj)	// Implement the method.
		{
			MyClass mc = (MyClass)obj;
			if (TheValue < mc.TheValue)
			{
				return -1;
			}
			if (TheValue > mc.TheValue)
			{
				return 1;
			}
			return 0;
		}
	}

    class Program
    {
		static void PrintOut(string s, MyClass[] mcArray)
		{
			Console.Write(s);
			foreach (var item in mcArray)
			{
				Console.Write(item.TheValue + " ");
			}
			Console.WriteLine("");
		}

        static void Main(string[] args)
        {
			int[] myInt = new int[5] { 1, 4, 2, 5, 3 };
			MyClass[] mcArray = new MyClass[5];		// Create array of MyClass objs.
			for (int i = 0; i < mcArray.Length; i++)// Initialize the array.
			{
				mcArray[i] = new MyClass();
				mcArray[i].TheValue = myInt[i];
			}
			PrintOut("Initial Order: ", mcArray);	// Print the initial array
			Array.Sort(mcArray);					// Sort the array.
			PrintOut("Sorted Order: ", mcArray);	// Print the sorted array.
		}
	}
}