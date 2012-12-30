using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class Employee
	{
		public string LastName;
		public string FirstName;
		public string CityOfBirth;

		public string this [int index]		// Indexer declaration
		{
			set		// Set accessor declaration
			{
				switch(index)
				{
					case 0 : LastName = value; break;
					case 1 : FirstName = value; break;
					case 2 : CityOfBirth = value; break;

					default : throw new ArgumentOutOfRangeException("index");
				}
			}
			get		// Get accessor declaration
			{
				switch(index)
				{
					case 0: return LastName;
					case 1: return FirstName;
					case 2: return CityOfBirth;

					default: throw new ArgumentOutOfRangeException("index");
				}
			}
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Employee e = new Employee();
			e[0] = "hello";
			e[1] = "hi";
			e[2] = "wow";
			Console.WriteLine(e[0]);
			Console.WriteLine(e[1]);
			Console.WriteLine(e[2]);
		}
	}
}