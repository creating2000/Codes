using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	class Animal				// Base class.
	{
		public int Legs = 4;
	}
	class Dog : Animal			// Derived class.
	{
		
	}

	delegate T Factory<out T> (); // out before T

    class Program
    {
		static Dog MakeDog()
		{
			return new Dog();
		}

        static void Main(string[] args)
        {
			Factory<Dog> dogMaker = MakeDog;		// Create delegate object.
			Factory<Animal> animalMaker = dogMaker; // Attempt to assign delegate object.
			// But Factory<Animal> want an object of Animal.
			Console.WriteLine(animalMaker().Legs.ToString());
		}
	}
}