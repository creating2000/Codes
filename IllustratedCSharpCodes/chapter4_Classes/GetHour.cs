using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class MyClass
	{
		public int GetHour()
		{
			DateTime dt = DateTime.Now;
			int hour	= dt.Hour;
			return hour;
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			Console.WriteLine("Hour: {0}", mc.GetHour());
		}
	}
}