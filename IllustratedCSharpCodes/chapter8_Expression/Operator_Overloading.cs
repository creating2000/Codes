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
			LimitedInt x = new LimitedInt();
			// int y = 10 + 10;
			x = 50; // implicit user defined conversion
			x = x + 30.3; // operator overloading
			Console.WriteLine("x: {0}", x.TheValue);
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

		// operator overloading
		public static LimitedInt operator + (LimitedInt x, double y)
		{
			LimitedInt li = new LimitedInt();
			li.TheValue = x.TheValue + (int)y;
			return li;
		}

		public static LimitedInt operator - (LimitedInt x)
		{
			LimitedInt li = new LimitedInt();
			li.TheValue = 0;
			return li;
		}
		
		// implicit conversion
		public static implicit operator LimitedInt (int x)
		{
			LimitedInt li = new LimitedInt();
			li.TheValue = x;
			return li;
		}
	}
}