using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices; // need this.

namespace Reflection
{
    class Program
    {
		private static void MyTrace(string message, 
									[CallerFilePath] string filePath = "", // implicit source code's file path.
									[CallerLineNumber] int lineNumber = 0, // implicit the line number of the line where the method was called.
									[CallerMemberName] string memberName = "") // implicit the name of the member calling the method.
		{
			Console.WriteLine("File: {0}", filePath);
			Console.WriteLine("Line: {0}", lineNumber);
			Console.WriteLine("Called from: {0}", memberName);
			Console.WriteLine("Message: {0}", message);
		}

        static void Main(string[] args)
        {
			MyTrace("Simple message"); // implicit
			Console.WriteLine();
			MyTrace("Simple message", "hello", 10, "jack");// explicit
		}
	}
}