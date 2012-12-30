using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	interface ILiveBirth				// Declare interface.
	{
		string BabyCalled();
	}
	class Animal						// Declare base class.
	{
	}

	class Cat : Animal, ILiveBirth		// Declare class Cat.
	{
		string ILiveBirth.BabyCalled()
		{
			return "kitten";
		}
	}

	class Dog : Animal, ILiveBirth		// Declare class Dog.
	{
		string ILiveBirth.BabyCalled()
		{
			return "puppy";
		}
	}

	class Bird : Animal					// Declare class Bird.
	{
	}

    class Program
    {
        static void Main(string[] args)
        {
			Animal[] animalArray = new Animal[3];	// Create animal array.
			animalArray[0] = new Cat();				// Insert Cat class object.
			animalArray[1] = new Bird();			// Insert Bird class object.
			animalArray[2] = new Dog();				// Insert Dog class object.

			foreach (Animal a in animalArray)		
			{
				ILiveBirth b = a as ILiveBirth;		// if implements ILiveBirth..
				if (b != null)
				{
					Console.WriteLine("Baby is called: {0}", b.BabyCalled());
				}
			}
		}
	}
}