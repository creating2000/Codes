using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
	class Other
	{
		static public string Name = "Jack";	// Static field
	}
    class Program
    {
        static void Main(string[] args)
        {
			string Major = "History";	// Local variable

			var student = new { Age = 19, Other.Name, Major };

			Console.WriteLine("{0}, Age {1}, Major {2}", student.Name, student.Age, student.Major);
		}
	}
}