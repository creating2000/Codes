using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection
{
    class Program
    {
		// [Obsolete("Use method SuperPrintOut")] // Apply attribute to a method.only warning message.
		[Obsolete("Use method SuperPrintOut", true)] // Apply attribute to a method. error message.
		public static void PrintOut(string str)
		{
			Console.WriteLine(str);
		}

        static void Main(string[] args)
        {
			PrintOut("Start of Main");	// Invoke the obsolete method.
		}
	}
}