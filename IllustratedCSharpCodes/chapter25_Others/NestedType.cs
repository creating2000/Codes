using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
	class MyClass
	{
		class MyCounter // Nested class
		{
			public int Count
			{
				get;
				private set;
			}

			public static MyCounter operator ++(MyCounter current)
			{
				current.Count++;
				return current;
			}
		}

		private MyCounter _counter;			// Field of nested class type.
		public MyClass()					// Constructor.
		{
			_counter = new MyCounter();		
		}

		public int Incr()// Increment method.
		{
			return (_counter++).Count;
		}

		public int GetValue() // Get counter value.
		{
			return _counter.Count;
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			mc.Incr();
			mc.Incr();
			mc.Incr();

			Console.WriteLine("Total: {0}", mc.GetValue());
		}
	}
}