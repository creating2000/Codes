using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
	class MyClass
	{
		public static void PrintArg(string arg)
		{
			try
			{
				if (arg == null)
				{
					// Supply the name of the null argument.
					ArgumentNullException myEx = new ArgumentNullException("arg");
					throw myEx;
				}
				Console.WriteLine(arg);
			}
			catch (ArgumentNullException e)
			{
				Console.WriteLine("Message: {0}", e.Message);
			}
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			string s = null;
			MyClass.PrintArg(s);
			MyClass.PrintArg("jack");
		}
	}
}