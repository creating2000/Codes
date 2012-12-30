using System;
using System.Linq;

namespace LINQ
{
	public class Student
	{
		public int StID;
		public string LastName;
	}

	public class CourseStudent
	{
		public string CourseName;
		public int StID;
	}

	class Program
	{
		static Student[] students = new Student[]
		{
			new Student { StID = 1, LastName = "Carson" },
			new Student { StID = 2, LastName = "Klassen" },
			new Student { StID = 3, LastName = "Fleming" },
		};

		static CourseStudent[] studentInCourses = new CourseStudent[]
		{
			new CourseStudent { CourseName = "Art",		StID = 1 },
			new CourseStudent { CourseName = "Art",		StID = 2 },
			new CourseStudent { CourseName = "History", StID = 1 },
			new CourseStudent { CourseName = "History", StID = 3 },
			new CourseStudent { CourseName = "Physics", StID = 3 },
		};

		static void Main()
		{
			var query = from s in students
						join c in studentInCourses on s.StID equals c.StID
						where c.CourseName == "History"
						select s.LastName;

			foreach (var item in query)
			{
				Console.WriteLine("Student taking History: {0}", item);
			}
		}
	}
}