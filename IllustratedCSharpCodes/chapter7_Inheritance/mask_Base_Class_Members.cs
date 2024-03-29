using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
	class SomeClass		// Base class
	{	
		public string Field1 = "SomeClass Field1";
		public void	Method1(string value)
		{
			Console.WriteLine("SomeClass.Method1: {0}", value);
		}
	}

	class OtherClass : SomeClass	// Derived class
	{
		new public string Field1 = "OtherClass Field1";	// Mask the base member.
		new public void Method1(string value)			// Mask the base member.
		{
			Console.WriteLine("OtherClass.Method1: {0}", value);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			OtherClass oc = new OtherClass();
			oc.Method1(oc.Field1);	// Use the masking member.
		}
	}
}