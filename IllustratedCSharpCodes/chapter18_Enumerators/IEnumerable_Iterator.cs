using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterators
{
	// 1. Make the class itself enumerable by implementing the GetEnumerator
	class MyClass 
	{
		public IEnumerator<string> GetEnumerator()
		{
			// Get enumerable.
			IEnumerable<string> myEnumerable = WriteAndBlack();
			// Get enumerator
			return myEnumerable.GetEnumerator();
		}
		
		// Returns an enumerable.
		public IEnumerable<string> WriteAndBlack()
		{
			yield return "Write";
			yield return "and";
			yield return "Black";
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			// Use the class object.
			foreach (string shade in mc)
			{
				Console.Write(shade + "\t");
			}
			
			// Use the class iterator method.
			foreach (string shade in mc.WriteAndBlack())
			{
				Console.Write(shade + "\t");
			}
		}
	}
}