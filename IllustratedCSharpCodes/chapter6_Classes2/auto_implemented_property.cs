using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class C1
	{
		// No declared backing field
		public int MyValue			// Allocates memory
		{
			get;
			set;	// The bodies of the accessors are declared as semicolons
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			C1 c = new C1();
			Console.WriteLine("MyValue: {0}", c.MyValue);
			// Use auto-implemented properties as regular properties.
			c.MyValue = 20;
			Console.WriteLine("MyValue: {0}", c.MyValue);
		}
	}
}