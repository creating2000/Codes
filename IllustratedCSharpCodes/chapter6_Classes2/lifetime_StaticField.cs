using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class D
	{
		int Mem1;
		static public int Mem2; // ×¢Òâpublic
	}

    class Program
    {
        static void Main(string[] args)
        {
			D.Mem2 = 5;
			Console.WriteLine("Mem2 = {0}", D.Mem2);
		}
	}
}