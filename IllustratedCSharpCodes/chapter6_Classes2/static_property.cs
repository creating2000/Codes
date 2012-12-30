using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class Trivial
	{
		public static int MyValue
		{
			get;
			set;
		}
		public void PrintValue()
		{
			Console.WriteLine("Value from inside: {0}", MyValue);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Init Value: {0}", Trivial.MyValue);
			Trivial.MyValue = 20;
			Console.WriteLine("New Value: {0}", Trivial.MyValue);

			Trivial tr = new Trivial();
			tr.PrintValue();
		}
	}
}