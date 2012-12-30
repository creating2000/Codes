using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structs
{
	class CSimple
	{
		public int X;
		public int Y;
	}

	struct Simple
	{
		public int X;
		public int Y;
	}

    class Program
    {
        static void Main(string[] args)
        {
			CSimple cs1 = new CSimple(), cs2 = null;
			Simple ss1 = new Simple(), ss2 = new Simple();

			cs1.X = ss1.X = 5;
			cs1.Y = ss1.Y = 10;

			cs2 = cs1;
			ss2 = ss1;

		}
	}
}