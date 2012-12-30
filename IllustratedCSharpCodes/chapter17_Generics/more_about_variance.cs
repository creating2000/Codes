using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	class Animal
	{
		public int Legs = 4;
	}
	class Dog : Animal
	{
		
	}

	delegate T Factory< out T> ();

    class Program
    {
		static Dog MakeDog()
		{
			return new Dog();
		}

        static void Main(string[] args)
        {
			// Coerced implicited
			Factory<Dog> dogMaker = MakeDog;
			Factory<Animal> animalMaker = MakeDog;
			
			// Requires the out specifier
			Factory<Animal> a1 = dogMaker;
			Factory<Animal> a2 = new Factory<Dog> (MakeDog);
		}
	}
}