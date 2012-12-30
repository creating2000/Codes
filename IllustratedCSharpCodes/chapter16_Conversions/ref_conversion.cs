using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversions
{
	class A
	{
		public int Field1 = 10;
	}
	class B : A
	{
		public int Field2 = 20;
	}

    class Program
    {
        static void Main(string[] args)
        {
			B myVar1 = new B();		
				
			// Return the reference to myVar1 as a reference to a class A.
			A myVar2 = (A)myVar1;
			Console.WriteLine(myVar2.Field1);// Fine
			Console.WriteLine(myVar2.Field2);// Compile error.
		}
	}
}