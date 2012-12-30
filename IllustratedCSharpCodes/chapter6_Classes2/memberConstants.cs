using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class X
	{
		public const double PI = 3.1416;
	}

    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Value of PI: {0}", X.PI);// Use static field	PI.	
		}
	}
}