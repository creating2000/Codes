using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class RandomNumberClass
	{
		private static Random randomKey;	// Private static field.

		static RandomNumberClass()			// Static constructor.
		{
			randomKey = new Random();		// Initialize randomKey.
		}

		public int GetRandomNumber()
		{
			return randomKey.Next();
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			RandomNumberClass a = new RandomNumberClass();
			RandomNumberClass b = new RandomNumberClass();

			Console.WriteLine("Next Random #: {0}", a.GetRandomNumber());
			Console.WriteLine("Next Random #: {0}", b.GetRandomNumber());
		}
	}
}