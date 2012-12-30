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
			for( int x = 1; x < 6; x++ )
			{
				switch (x)
				{
					case 5:
							Console.WriteLine("x is {0} -- In Case 5", x);
							break;
				}
			}

			for (int x = 1; x < 4; x++)
			{
				switch (x)
				{
					default: 
						Console.WriteLine("x is {0} -- In Case default", x);
						break;
				}
			}
		}
	}
}