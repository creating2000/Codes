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
			string s1 = "25.873";
			string s2 = "36.240";

			double d1 = double.Parse(s1);
			double d2 = double.Parse(s2);

			double total = d1 + d2;
			Console.WriteLine("Total: {0}", total);
		}
	}
}