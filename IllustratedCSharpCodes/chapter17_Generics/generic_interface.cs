using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	// Generic interface
	interface MyIfc<T>
	{
		T ReturnIt(T invalue);
	}
	
	// Generic class implement the generic interface.
	class Simple<S> : MyIfc<S>
	{
		public S ReturnIt(S invalue)
		{
			return invalue;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			var intSimple = new Simple<int> ();
			var stringSimple = new Simple<string> ();

			Console.WriteLine("intValue: {0}", intSimple.ReturnIt(10));
			Console.WriteLine("stringValue: {0}", stringSimple.ReturnIt("hello"));
		}
	}
}