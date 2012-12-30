using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	interface IIfc1			
	{
		void PrintOut(string s1);
	}
	interface IIfc2
	{
		void PrintOut(string s2);
	}

	class MyClass : IIfc1, IIfc2 // Implement both interfaces.
	{
		public void PrintOut(string s)	// Single implementation for both
		{
			Console.WriteLine("Calling through: {0}", s);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			mc.PrintOut("object");
		}
	}
}