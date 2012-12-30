using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterators
{
	// 2. Call method directly.
	class MyClass
	{
		// Do not implementing GetEnumerator
		public IEnumerable<string> WriteAndBlack()
		{
			yield return "111";
			yield return "222";
			yield return "333";
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			// Calling the iterator method directly.
			foreach (string item in mc.WriteAndBlack())
			{
				Console.WriteLine(item);
			}
		}
	}
}