using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
	class MyClass
	{
		public double GetCylinderVolume(double radius = 3.0, double height = 4.0)
		{
			return 3.1416 * radius * radius * height;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			double volume;

			volume = mc.GetCylinderVolume(3.0, 4.0);	// Positional.
			Console.WriteLine("Volume = " + volume);
			volume = mc.GetCylinderVolume(radius: 2.0);	// Use default height.
			Console.WriteLine("Volume = " + volume);
			volume = mc.GetCylinderVolume(height: 2.0);	// Use default radius.
			Console.WriteLine("Volume = " + volume);
			volume = mc.GetCylinderVolume();			// Use both default.
			Console.WriteLine("Volume = " + volume);
		}
	}
}