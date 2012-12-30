using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
			int x = +10;
			int y = -x;
			int z = -y;
			Console.WriteLine("x:{0}, y:{1}, z:{2}", x, y, z);
		}
	}
}