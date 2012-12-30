using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
		public void Count(int inVal)
		{
			if (inVal == 0)
			{
				return;
			}
			Count(inVal - 1);	// Invoke this method again.
			Console.WriteLine(inVal);
		}

        static void Main(string[] args)
        {
			Program p = new Program();
			p.Count(10);
		}
	}
}