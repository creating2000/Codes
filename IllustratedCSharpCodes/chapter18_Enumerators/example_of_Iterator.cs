using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterators
{
	class MyClass
	{
		// Returns the enumerator.
		public IEnumerator<string> GetEnumerator()
		{
			return WriteAndBlack();
		}

		// Iterator: returns an enumerator.
		public IEnumerator<string> WriteAndBlack()
		{
			yield return "write";
			yield return "and";
			yield return "black";
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			foreach (var item in mc) // Use the instance of MyClass.
			{
				Console.WriteLine(item);
			}
		}
	}
}