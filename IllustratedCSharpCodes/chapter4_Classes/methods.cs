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
			
		}

		void DisplayRadii()
		{
			const double PI = 3.1416;
			for (int radius = 1; radius <= 5; radius++)
			{
				double area = radius * radius * PI;
				Console.WriteLine("Radius: {0},	Area: {1}", radius, area);
			}
		}

		void SomeMethod()
		{
			int intVal = 3;
			if (intVal == 3)
			{
				Console.WriteLine("Value is 3");
			}

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Value of i {0}", i);
			}
		}

		int GetHour()
		{
			DateTime dt = DateTime.Now;		// Get the current date and time.
			int hour	= dt.Hour;			// Get the hour.		
			return hour;					// Return an int.
		}
	}
}