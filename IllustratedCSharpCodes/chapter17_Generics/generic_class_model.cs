using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	// Generic class Declaration: T1, T2: Type Parameters.
	class MyClass<T1, T2>
	{
		// T1, T2: Normally, types would be used in these positions.
		public T1 SomeVar  = new T1();
		public T2 OtherVar = new T2();
	}

	// Constructed Type: T1, T2: Type Arguments.
	class MyClass<short, int>
	{
		short SomeVar;
		int OtherVar;
	}

    class Program
    {
        static void Main(string[] args)
        {
			
		}
	}
}