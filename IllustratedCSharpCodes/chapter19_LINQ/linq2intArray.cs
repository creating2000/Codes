using System;
using System.Linq;

namespace LINQ
{
	class Program
	{
		static void Main()
		{
			int[] arr1 = { 10, 11, 12, 13 };

			var query = from item in arr1	// item is the Iteration variable
						where item < 13		// Use the iteration variable
						select item;		// Use the iteration variable

			foreach (var item in query)
			{
				Console.Write("{0}, ", item);
			}
		}
	}
}