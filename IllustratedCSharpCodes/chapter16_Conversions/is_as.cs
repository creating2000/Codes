using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversions
{
	class Employee : Person
	{
		
	}

	class Person
	{
		public string Name = "Anonymous";
		public int Age = 18;
	}

    class Program
    {
        static void Main(string[] args)
        {
			Employee e = new Employee();
			Person p;
			// Check if variable e can be converted to type Person.
			if (e is Person)
			{
				p = e;
				Console.WriteLine("Person info: {0}, {1}", p.Name, p.Age);
			}

			Person p1 = e as Person;
			if (p1 != null)
			{
				Console.WriteLine("Person info: {0}, {1}", p1.Name, p1.Age);
			}
		}
	}
}