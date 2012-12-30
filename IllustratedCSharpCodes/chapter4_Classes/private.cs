using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
	class DaysTemp
	{
		// Fields
		private int High = 75;
		private int Low = 45;

		// Methods
		private int GetHigh()
		{
			return High;						// Access the private field.
		}

		private int GetLow()
		{
			return Low;							// Access the private field.
		}

		public float Average()
		{
			return (GetHigh() + GetLow()) / 2;	// Access the private method.
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			DaysTemp dt = new DaysTemp();
			float avg = dt.Average();
			Console.WriteLine(avg);
		}
	}
}