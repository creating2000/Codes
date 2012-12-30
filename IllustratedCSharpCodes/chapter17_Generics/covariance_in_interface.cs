using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	class Animal
	{
		public string Name;
	}
	class Dog : Animal
	{
		
	}

	interface IMyIfc<out T>
	{
		T GetFirst();
	}

	class SimpleReturn<T> : IMyIfc<T>
	{
		public T[] items = new T[2];
		public T GetFirst()
		{
			return items[0];
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			SimpleReturn<Dog> dogReturner = new SimpleReturn<Dog> ();
			dogReturner.items[0] = new Dog() { Name = "damn" };

			IMyIfc<Animal> animalReturner = dogReturner;
			DoSth(animalReturner);
		}

		static void DoSth(IMyIfc<Animal> a)
		{
			Console.WriteLine(a.GetFirst().Name);			
		}
	}
}