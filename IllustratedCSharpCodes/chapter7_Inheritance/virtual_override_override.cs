using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
	class MyBaseClass
	{
		virtual public void Print()
		{
			Console.WriteLine("This is the base class");
		}
	}

	class MyDerivedClass : MyBaseClass
	{
		override public void Print()
		{
			Console.WriteLine("This is the derived class");
		}
	}

	class SecondDerived : MyDerivedClass
	{
		override public void Print()
		{
			Console.WriteLine("This is the second derived");
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			SecondDerived secondDerived = new SecondDerived();
			MyBaseClass mybc = (MyBaseClass)secondDerived;

			secondDerived.Print();
			mybc.Print(); // Up to SecondDerived
		}
	}
}