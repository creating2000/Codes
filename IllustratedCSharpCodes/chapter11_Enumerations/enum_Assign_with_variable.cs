using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerations
{
	enum TrafficLight
	{
		Green,
		Yellow,
		Red
	}

    class Program
    {
        static void Main(string[] args)
        {
			// Type		Variable	Member
			TrafficLight t1 = TrafficLight.Red; // Assign from member
			TrafficLight t2 = TrafficLight.Green;
			TrafficLight t3 = t2;		// Assign from variable

			Console.WriteLine(t1);
			Console.WriteLine(t2);
			Console.WriteLine(t3);
		}
	}
}