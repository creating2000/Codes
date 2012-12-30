using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
		static int[] numbers = new int[] { 2, 4, 6 };

        static void Main(string[] args)
        {
			int total = numbers.Sum();
			int howMany = numbers.Count();
			//			Sequence.Operator
			Console.WriteLine("Total: {0}, Count: {1}", total, howMany);
		}
	}
}