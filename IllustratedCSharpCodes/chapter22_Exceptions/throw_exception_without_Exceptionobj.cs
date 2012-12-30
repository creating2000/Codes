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
				try
				{
					if (arg == null)
					{
						ArgumentNullException myEx = new ArgumentNullException("arg");
						throw myEx;
					}
					Console.WriteLine(arg);
				}
				catch (ArgumentNullException e)
				{
					Console.WriteLine("Inner Catch: {0}", e.Message);
					throw;// Rethrow the exception, with no additional parameters.
				}
			}
			catch
			{
				Console.WriteLine("Outer Catch: Handing an exception.");
			}
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			string s = null;
			MyClass.PrintArg(s);
		}
	}
}