using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	class Animal
	{
		public int NumberOfLegs = 4;
	}

	class Dog : Animal
	{
		
	}

    class Program
    {
        static void Main(string[] args)
        {
			Animal a1 = new Animal();
			Animal a2 = new Dog();
			Console.WriteLine("Number of legs: {0}", a2.NumberOfLegs);
		}
	}
}