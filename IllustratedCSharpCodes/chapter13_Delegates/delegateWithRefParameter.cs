using System;

namespace Delegates
{
	delegate void MyDel(ref int X);

	class MyClass 
	{
		public void Add2(ref int x)
		{
			x += 2;
		}
		public void Add3(ref int x)
		{
			x += 3;
		}
	}

	class Program
	{
		static void Main()
		{
			MyClass mc = new MyClass();
			MyDel myDel = mc.Add2;

			myDel += mc.Add3;
			myDel += mc.Add2;

			int x = 5;
			myDel(ref x);

			Console.WriteLine("Value: {0}", x);
		}
	}
}