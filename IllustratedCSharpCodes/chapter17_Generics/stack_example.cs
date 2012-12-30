using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	class MyStack<T>
	{
		T[] StackArray;
		int StackPointer = 0;
		
		int MaxStack = 10;
		bool IsStackFull
		{
			get 
			{ 
				return StackPointer >= MaxStack; 
			}
		}
		bool IsStackEmpty
		{
			get 
			{ 
				return StackPointer <= 0; 
			}
		}

		public MyStack()
		{
			StackArray = new T[MaxStack];
		}

		public void Push(T x)
		{
			if (!IsStackFull)
			{
				StackArray[StackPointer++] = x;
			}
		}
		public T Pop()
		{
			return (!IsStackEmpty )
					? StackArray[--StackPointer]
					: StackArray[0];
		}

		public void Print()
		{
			for (int i = StackPointer - 1; i >= 0; i--)
			{
				Console.WriteLine(" Value: {0}", StackArray[i]);
			}
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			MyStack<int> stackInt = new MyStack<int> ();
			stackInt.Push(9);
			stackInt.Push(8);
			stackInt.Push(7);
			stackInt.Push(6);
			stackInt.Print();

			MyStack<string> stackString = new MyStack<string> ();
			stackString.Push("hello, jack.");
			stackString.Push("hi, kate.");
			stackString.Push("God, we're lost");
			stackString.Print();
		}
	}
}