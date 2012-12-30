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
			// cast operator (explicit convert)
			LimitedInt li = (LimitedInt) 900;
			int value = (int)li;
			Console.WriteLine("li:{0}, value:{1}", li.TheValue, value);
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

		public static explicit operator int (LimitedInt li)
		{
			return li.TheValue;
		}

		public static explicit operator LimitedInt (int x)
		{
			LimitedInt li = new LimitedInt();
			li.TheValue = x;
			return li;
		}
	}
}