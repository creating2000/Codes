using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
	delegate void PrintMessage(int x);

    class Program
    {
		public static void Method1()
		{
			Console.WriteLine("in method1");
		}

        static void Main(string[] args)
        {
			PrintMessage pm = delegate // no parameter can match delegate!
							{
								Console.WriteLine("hello--{0}");		
							};
			// pm += Program.Method1; // no parameter cannot match delegate!
			pm(5); // Parameter is needed.
		}
	}
}