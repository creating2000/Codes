using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
		void PrintDateAndTime()			// Declare the method
		{
			DateTime dt = DateTime.Now;	// Get the current date and time.
			Console.WriteLine(dt);		// Write it out.
		}

        static void Main(string[] args)
        {
			Program p = new Program();
			p.PrintDateAndTime();		// Invoke the method.
		}
	}
}