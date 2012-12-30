using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // for Timer

namespace Asynchronous
{
    class Program
    {
		private int _timeCalled = 0;
		void Display(object state)
		{
			Console.WriteLine("{0} {1}", (string)state, ++_timeCalled);
		}

        static void Main(string[] args)
        {
			Program p = new Program();
			// First callback at 2 seconds, repeat every second.
			Timer myTimer = new Timer(p.Display, "Processing timer event ", 2000, 1000);
			Console.WriteLine("Timer started.");
			// Console.ReadLine();
			Thread.Sleep(7000);
		}
	}
}