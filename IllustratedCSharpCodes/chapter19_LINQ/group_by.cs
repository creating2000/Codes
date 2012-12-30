using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
			var students = new []
			{
				new { LName = "Jones", FName = "Mary", Age = 19, Major = "History" },
				new { LName = "Smith", FName = "Bob", Age = 20, Major = "CompSci" },
				new { LName = "Fleming", FName = "Carol", Age = 21, Major = "History" }
			}; // Array of objects of anonymous type

			var query = from student in students
						group student by student.Major;

			foreach (var s in query)						// Enumerate the groups
			{
				Console.WriteLine("{0}:", s.Key);

				foreach (var t in s)
				{
					Console.WriteLine("\t{0}, {1}", t.LName, t.FName);	// Enumerate the items in the group
				}
			}
		}
	}
}