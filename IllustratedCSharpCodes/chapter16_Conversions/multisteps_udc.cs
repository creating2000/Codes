using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversions
{
	class Person
	{
		public string Name;
		public int Age;
		// Convert a Person object to an int.
		public static implicit operator int(Person p)
		{
			return p.Age;
		}
	}

	class Employee : Person
	{
		
	}

    class Program
    {
        static void Main(string[] args)
        {
			Employee bill = new Employee();
			bill.Name = "Jack";
			bill.Age = 18;
			
			// Convert Employee to float.
			float f = bill;
			Console.WriteLine("Person info: {0}, {1}", bill.Name, f);
		}
	}
}