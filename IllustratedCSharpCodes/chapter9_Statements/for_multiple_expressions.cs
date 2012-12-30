using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
			const int MaxI = 5;
			//   Two declarations				Two expressions
			for (int i = 0, j = 10; i < MaxI; i++, j += 10)
			{
				Console.WriteLine("{0}, {1}", i, j);
			}
		}
	}
}