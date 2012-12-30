using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	interface IIfc1			// Declare interface.
	{
		void PrintOut(string s);
	}

	class MyClass : IIfc1		// Declare class.
	{
		public void PrintOut(string s)	// Implementation
		{
			Console.WriteLine(s);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass(); // Create instance
			mc.PrintOut("jack_kate");	// Call method

			IIfc1 ifc = (IIfc1)mc; // cast the reference to the class obj to the interface type.
			ifc.PrintOut("hello"); // use reference to interface to call member.
		}
	}
}