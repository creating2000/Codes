using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
			Type t = typeof(SomeClass);
			Console.WriteLine(t.GetType().Name); // Type of Class

			SomeClass sc = new SomeClass();
			Console.WriteLine(sc.GetType().Name);// Type of instance of Class
		}
	}

	class SomeClass
	{
	}
}