using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	delegate void MyDelegate<T> (T value);	// Generic delegate.

	class Simple
	{
		public static void PrintString(string s)	// Method matches delegate.
		{
			Console.WriteLine(s);
		}

		public static void PrintUpperString(string s) // Method matches delegate.
		{
			Console.WriteLine(s.ToUpper());
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			// Create inst of the delegate.
			var myDel = new MyDelegate<string> (Simple.PrintString);
			// Add a method.
			myDel += Simple.PrintUpperString;
			// Call the delegate.
			myDel("Hello, Jack!");
		}
	}
}