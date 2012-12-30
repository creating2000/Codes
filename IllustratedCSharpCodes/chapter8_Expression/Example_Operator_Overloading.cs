using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
			LimitedInt li1 = new LimitedInt();
			LimitedInt li2 = new LimitedInt();
			LimitedInt li3 = new LimitedInt();

			li1.TheValue = 10;
			li2.TheValue = 20;
			Console.WriteLine("li1: {0}, li2: {1}", li1.TheValue, li2.TheValue);
			li3 = -li1;
			Console.WriteLine("-{0} = {1}", li1.TheValue, li3.TheValue);
			li3 = li1 + li2;
			Console.WriteLine("{0} + {1} = {2}", li1.TheValue, li2.TheValue, li3.TheValue);
			li3 = li1 - li2;
			Console.WriteLine("{0} - {1} = {2}", li1.TheValue, li2.TheValue, li3.TheValue);
			li3 = li2 - li1;
			Console.WriteLine("{0} - {1} = {2}", li2.TheValue, li1.TheValue, li3.TheValue);
			li3 = li1 + 55.1;
			Console.WriteLine("{0} + {1} = {2}", li1.TheValue, 55.1, li3.TheValue);
///			li3 = li1 - 3; // no corresponding overloading. cannot do this!
///			Console.WriteLine("{0} - {1} = {2}", li1.TheValue, 3, li3.TheValue);
		}
	}

	class LimitedInt
	{
		const int MaxValue = 100;
		const int MinValue = 0;

		private int _theValue;
		public int TheValue
		{
			get
			{
				return _theValue;
			}
			set
			{
				if (value < MinValue)
				{
					_theValue = 0;
				}
				else
				{
					_theValue = value > MaxValue
										? MaxValue
										: value;
				}
			}
		}

		public static LimitedInt operator - (LimitedInt x)
		{
			LimitedInt li = new LimitedInt();
			li.TheValue = 0;
			return li;
		}

		public static LimitedInt operator - (LimitedInt x, LimitedInt y)
		{
			LimitedInt li = new LimitedInt();
			li.TheValue = x.TheValue - y.TheValue;
			return li;
		}
		
		public static LimitedInt operator + (LimitedInt x, LimitedInt y)
		{
			LimitedInt li = new LimitedInt();
			li.TheValue = x.TheValue + y.TheValue;
			return li;
		}

		public static LimitedInt operator + (LimitedInt x, double y)
		{
			LimitedInt li = new LimitedInt();
			li.TheValue = x.TheValue + (int)y;
			return li;
		}
	}
}