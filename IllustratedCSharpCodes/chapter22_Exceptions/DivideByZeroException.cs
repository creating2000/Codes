using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
			int x = 10;
			try
			{
				int y = 0;
				x /= y;
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Message: {0}", e.Message);
				Console.WriteLine("Source: {0}", e.Source);
				Console.WriteLine("StackTrace: {0}", e.StackTrace);
			}
		}
	}
}