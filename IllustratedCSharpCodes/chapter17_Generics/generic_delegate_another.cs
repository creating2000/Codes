using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	// Generic delegate.
	public delegate TR Func<T1, T2, TR> (T1 f1, T2 f2);

	class Simple
	{
		// Method matches the delegate.
		public static string PrintString(int f1, int f2)
		{
			int total = f1 + f2;
			return total.ToString();
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			// Create inst of the delegate.
			var myDel = new Func<int, int, string> (Simple.PrintString);
			// Call the delegate.
			Console.WriteLine("{0}", myDel(14, 15));
		}
	}
}