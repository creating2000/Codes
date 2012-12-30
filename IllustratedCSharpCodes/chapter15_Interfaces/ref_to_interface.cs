using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	interface IIfc1
	{
		void PrintOut(string s);
	}

	class MyClass : IIfc1
	{
		public void PrintOut(string s)
		{
			Console.WriteLine("Calling through: {0}", s);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();	// Create class object.
			mc.PrintOut("Object");		// Call class object implementation method.

			IIfc1 ifc = (IIfc1)mc;		// Cast class object ref to interface ref.
			ifc.PrintOut("Interface");	// Call interface method.
		}
	}
}