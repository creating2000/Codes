
#define DoTrace	// Comment out the line or not.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; // need this

namespace Reflection
{
    class Program
    {
		[Conditional("DoTrace")]
		public static void TraceMessage(string str)
		{
			Console.WriteLine(str);
		}

        static void Main(string[] args)
        {
			TraceMessage("Start of Main");
			Console.WriteLine("Doing work in Main");
			TraceMessage("End of Main");
		}
	}
}