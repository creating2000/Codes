using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class MyClass
	{
		int Var1 = 10;
		public int ReturnMaxValue(int Var1)
		{
			return Var1 > this.Var1
						? Var1
						: this.Var1;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			Console.WriteLine("max: {0}", mc.ReturnMaxValue(5));
			Console.WriteLine("max: {0}", mc.ReturnMaxValue(20));
		}
	}
}