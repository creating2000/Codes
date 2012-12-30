using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
	class MyClass
	{
		public double GetCylinderVolume(double radius, double height) // pay attention to public
		{
			return 3.1416 * radius  * radius * height;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			double volume, volume1;
			volume = mc.GetCylinderVolume(3.0, 4.0);
			volume1 = mc.GetCylinderVolume(radius:3.0, height:4.0);

			Console.WriteLine(volume);
			Console.WriteLine(volume1);
		}
	}
}