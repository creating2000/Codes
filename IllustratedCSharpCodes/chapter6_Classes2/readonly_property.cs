using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class RightTriangle
	{
		public double A = 3;
		public double B = 4;
		public double Hypotenuse		// Read-only property
		{
			get
			{
				return Math.Sqrt((A * A + (B * B)));// Calculate return value
			}
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			RightTriangle c = new RightTriangle();
			Console.WriteLine("Hypotenuse: {0}", c.Hypotenuse);
		}
	}
}