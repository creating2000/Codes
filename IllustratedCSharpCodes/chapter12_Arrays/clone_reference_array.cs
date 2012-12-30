using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
	class MyClass
	{
		public int MyField = 5;
	}

    class Program
    {
        static void Main(string[] args)
        {
			// Cloning a reference type array produces two arrays referencing the same objects.
			MyClass[] mcArray = new MyClass[3] { new MyClass(), new MyClass(), new MyClass() };		
			MyClass[] mcClone = (MyClass[])mcArray.Clone();
			mcClone[0].MyField = 10;
			mcClone[1].MyField = 10;
			mcClone[2].MyField = 10;

			for (int i = 0; i < mcArray.Length; i++)
			{
				Console.WriteLine("mcArray: {0}, mcClone: {1}", mcArray[i].MyField, mcClone[i].MyField);
			}
			
		}
	}
}