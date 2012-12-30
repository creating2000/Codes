using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfaces
{
	interface IIfc1
	{
		void PrintOut(string s);
	}

	class MyClass : IIfc1
	{
		void IIfc1.PrintOut(string s)
		{
			Console.WriteLine("Calling through: {0}", s);
		}

		public void Method1()
		{
			// PrintOut("hello");
			// this.PrintOut("hi");
			((IIfc1)this).PrintOut("Got it."); // this: current object.
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			mc.Method1();
		}
	}
}