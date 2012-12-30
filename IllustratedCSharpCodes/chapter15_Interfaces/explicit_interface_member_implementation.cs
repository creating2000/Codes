using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	interface IIfc1		// Declare interface.
	{
		void PrintOut(string s);
	}
	interface IIfc2		// Declare interface.
	{
		void PrintOut(string t);
	}

	class MyClass : IIfc1, IIfc2	
	{
		void IIfc1.PrintOut(string s)			// Explicit interface member implementation
		{
			Console.WriteLine("IIfc1: {0}", s);
		}

		void IIfc2.PrintOut(string t)			// Explicit interface member implementation
		{
			Console.WriteLine("IIfc2: {0}", t);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();			// Create class object.

			IIfc1 ifc1 = (IIfc1)mc;				// Get ref to IIfc1
			IIfc2 ifc2 = mc as IIfc2;			// Get ref to IIfc2

			ifc1.PrintOut("interface1");		// Call explicit implementation
			ifc2.PrintOut("interface2");		// Call explicit implementation
		}
	}
}