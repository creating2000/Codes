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
			Console.WriteLine("Second member of TrafficLight is {0}", Enum.GetName(typeof(TrafficLight), 1));
			foreach (var name in Enum.GetNames(typeof(TrafficLight)))
			{
				Console.WriteLine(name);
			}
		}
	}
}