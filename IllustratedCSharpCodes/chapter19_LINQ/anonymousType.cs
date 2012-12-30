using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
	class Program
	{
		static void Main()
		{
			// Must use the var keyword
			var student = new { Name="Jack", Age=19, Major="History" };

			Console.WriteLine("{0}, Age {1}, Major {2}", student.Name, student.Age, student.Major);
		}
	}
}