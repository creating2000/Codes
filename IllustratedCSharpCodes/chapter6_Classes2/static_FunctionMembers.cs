using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class X
	{
		static public int A;			// Static field.
		static public void PrintValA()	// Static method.
		{
			Console.WriteLine("Value of A : {0}", A);// Accessing the static field
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			X.A = 10;		// Use dot-syntax notation.
			X.PrintValA();	// Use dot-syntax notation.
		}
	}
}