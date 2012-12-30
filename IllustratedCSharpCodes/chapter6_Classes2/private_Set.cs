using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class Person
	{
		public string Name
		{
			get;
			private set;		// Only can access inside the Person
		}
		
		public Person(string name)
		{
			Name = name;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Person p = new Person("Jack");		
			Console.WriteLine("Person's name is {0}", p.Name);
		}
	}
}