using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfaces
{
	interface IIfc1		// Declare interface.
	{
		void PrintOut(string s);
	}

	interface IIfc2		// Declare interface.
	{
		void PrintOut(string s);
	}

	class MyClass : IIfc1, IIfc2	// Declare class 
	{
		public void PrintOut(string s) // Implement the interfaces
		{
			Console.WriteLine("Calling through: {0}", s);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();

			IIfc1 ifc1 = (IIfc1)mc;		// Get ref to IIfc1.
			IIfc2 ifc2 = mc as IIfc2;	// Get ref to IIfc2.

			mc.PrintOut("object");			// Calling through object.
			ifc1.PrintOut("interface1");	// Calling through IIfc1.
			ifc2.PrintOut("interface2");	// Calling through IIfc2.
		}
	}
}