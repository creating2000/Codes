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
			for (int x = 0; x < 5; x++)	// Execute loop five times.
			{
				if (x < 3)	// The first three times 
				{
					continue;// Go directly back to top of loop.
				}
				// This line is only reached when x is 3 or grater.
				Console.WriteLine("Value of x is {0}", x);
			}

			int y = 0;
			while (y < 5)
			{
				if (y < 3)
				{
					y++;
					continue;// Go back to top of loop.
				}

				// This line is only reached when y is 3 or grater.
				Console.WriteLine("Value of y is {0}", y);
				y++;
			}
			
		}
	}
}