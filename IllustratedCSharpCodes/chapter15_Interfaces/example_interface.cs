using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	interface IInfo
	{
		string GetName();
		string GetAge();
	}

	class CA : IInfo
	{
		public string Name;
		public int Age;
		
		public string GetName()
		{
			return Name;
		}
		public string GetAge()
		{
			return Age.ToString();
		}
	}

	class CB : IInfo
	{
		public string First;
		public string Second;
		public double PersonsAge;

		public string GetName()
		{
			return First + " " + Second;
		}
		public string GetAge()
		{
			return PersonsAge.ToString();
		}
	}

    class Program
    {
		static void PrintInfo(IInfo item)
		{
			Console.WriteLine("Name: {0}, Age: {1}", item.GetName(), item.GetAge());
		}

        static void Main(string[] args)
        {
			CA a = new CA() { Name = "jack hello", Age = 18 };
			CB b = new CB() { First = "kate", Second = "hi", PersonsAge = 21 };

			PrintInfo(a);
			PrintInfo(b);
		}
	}
}