using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
	class SomeClass			// Base class
	{
		public string Field1 = "Field1 -- in the base class";
	}

	class OtherClass : SomeClass	// Derived class
	{
		new public string Field1 = "Field1 -- in the derived class";
		public void PrintField1()
		{
			Console.WriteLine(Field1);		// Access the derived class.
			Console.WriteLine(base.Field1);	// Access the base class.
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			OtherClass oc = new OtherClass();
			oc.PrintField1();
		}
	}
}