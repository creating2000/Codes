using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class Class1
	{
		int Temp0;
		int Temp1;

		public int this [int index]
		{
			get
			{
				return (0 == index)
						? Temp0
						: Temp1;
			}
			set
			{
				if (index == 0)
				{
					Temp0 = value;
				}
				else
				{
					Temp1 = value;
				}
			}

		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			Class1 c = new Class1();
			Console.WriteLine("Values -- Temp0: {0}, Temp1: {1}", c[0], c[1]);
			c[0] = 10;
			c[1] = 20;
			Console.WriteLine("Values -- Temp0: {0}, Temp1: {1}", c[0], c[1]);
		}
	}
}