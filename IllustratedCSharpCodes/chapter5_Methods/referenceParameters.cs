using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
	class MyClass
	{
		public int Val = 20;						// Initialize the field to 20.
	}

    class Program
    {	
		static void MyMethod(ref MyClass f1, ref int f2)
		{
			f1.Val = f1.Val + 5;		// Add 5 to field of f1 param.
			f2	   = f2 + 5;			// Add 5 to second param.

			Console.WriteLine("f1.Val: {0}, f2: {1}", f1.Val, f2);
		}

        static void Main(string[] args)
        {
			MyClass a1 = new MyClass();
			int		a2 = 20;
			
			MyMethod(ref a1, ref a2);				// Call the method.
			Console.WriteLine("f1.Val: {0}, f2: {1}", a1.Val, a2);
		}
	}
}