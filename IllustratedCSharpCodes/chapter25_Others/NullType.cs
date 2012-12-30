using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    class Program
    {
        static void Main(string[] args)
        {
			// 1.
			int? myInt = 17;
			if (myInt != null)
			{
				Console.WriteLine("myInt: {0}", myInt);
			}

			// 2.
			int? myInt1 = 15;			// Implicitly convert int to int?
			int myInt2 = (int)myInt1;   // Explicitly convert int? to int
			Console.WriteLine("myInt1: {0}, myInt2: {1}", myInt1, myInt2);

			// 3.
			int? myI1, myI2, myI3;
			myI1 = 18;		// Value of underlying type.
			myI2 = myI1;	// Value of nullable type.
			myI3 = null;	// null.
			Console.WriteLine("myI1: {0}, myI2: {1}, myI3: {2}", myI1, myI2, myI3);

			// 4.
			int? myI4 = null;
			Console.WriteLine("myI4: {0}", myI4 ?? -1);

			myI4 = 10;
			Console.WriteLine("myI4: {0}", myI4 ?? -1);
		}
	}
}