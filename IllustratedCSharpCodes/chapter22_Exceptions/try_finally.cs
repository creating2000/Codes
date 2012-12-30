using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
			int inVal = 3;
			try
			{
				if (inVal < 10)
				{
					Console.WriteLine("First Branch");
					return; // finally will always executed.
				}
				else
				{
					Console.WriteLine("Second Branch");
				}
			}
			finally
			{
				Console.WriteLine("In Finally statement.");
			}
		}
	}
}