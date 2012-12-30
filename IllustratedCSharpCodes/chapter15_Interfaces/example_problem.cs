using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	class CA
	{
		public string Name;
		public int Age;
	}

	class CB
	{
		public string First;
		public string Second;
		public double PersonsAge;
	}

    class Program
    {
		static void PrintInfo(CA item)
		{
			Console.WriteLine("Name: {0}, Age: {1}", item.Name, item.Age);
		}

        static void Main(string[] args)
        {
			CA a = new CA() { Name = "jack", Age = 18 };
			PrintInfo(a);
		}
	}
}