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
			};
			
			var query = from student in students
						orderby student.Age
						select student;

			var query1 = from student in students
							select student;

			var query2 = from student in students
							select student.LName;
			
			var query3 = from student in students
							select new { student.LName, student.FName, student.Major}; // Anonymous type

			foreach (var s in query)
			{
				Console.WriteLine(s);
			}

			Console.WriteLine("===============================================================");
			foreach (var s1 in query1)
			{
				Console.WriteLine("{0}, {1}, Age: {2}, {3}", s1.LName, s1.FName, s1.Age, s1.Major);
			}

			Console.WriteLine("===============================================================");
			foreach (var s2 in query2)
			{
				Console.WriteLine(s2);
			}

			Console.WriteLine("===============================================================");
			foreach (var s3 in query3)
			{
				Console.WriteLine(s3.LName + s3.FName + "--" + s3.Major);
			}


		}
	}
}