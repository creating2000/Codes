using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class MyClass
	{
		public void TimeUpdate()		// public 
		{
			DateTime dt = DateTime.Now;
			if (dt.Hour < 12)
			{
				return;
			}
			Console.WriteLine("It's afternoon!");
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			mc.TimeUpdate();
		}
	}
}