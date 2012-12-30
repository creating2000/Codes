using System;

namespace Delegates
{
	delegate int MyDel(); // Declare a delegate with return value

	class MyClass
	{
		int IntValue = 5;
		public int Add2()
		{
			IntValue += 2;
			return IntValue;
		}
		public int Add3()
		{
			IntValue += 3;
			return IntValue;
		}
	}

	class Program
	{
		static void Main()
		{
			MyClass mc = new MyClass();
			MyDel myDel = mc.Add2;	// Create and initialize the delegate.

			myDel += mc.Add3;	// Add a method.
			myDel += mc.Add2;	// Add a method.
			Console.WriteLine("Value: {0}", myDel()); // Invoke the delegate and use the return value.
		}
	}
}