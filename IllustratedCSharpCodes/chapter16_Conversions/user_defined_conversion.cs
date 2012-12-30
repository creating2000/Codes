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
		public Person (string name, int age)
		{
			Name = name;
			Age = age;
		}
		
		// Convert Person to int.
		public static implicit operator int(Person p)
		{
			return p.Age;
		}

		// Convert int to Person.
		public static implicit operator Person(int i)
		{
			return new Person("Nemo", i);
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			Person bill = new Person("bill", 18);

			// Convert an person object to an int.
			int age = bill;
			Console.WriteLine("Person info: {0}, {1}", bill.Name, age);
			
			// Convert an int to a person object.
			Person anon = 30;
			Console.WriteLine("Person info: {0}, {1}", anon.Name, anon.Age);
		}
	}
}