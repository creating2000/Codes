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
			// implicit convert
			LimitedInt li = 800;
			int value = li;
			Console.WriteLine("li:{0}, x:{1}", li.TheValue, value);
		}
	}

	class LimitedInt
	{
		const int MaxValue = 100;
		const int MinValue = 0;

		private int _theValue;
		public int TheValue		// Property
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
		

		// Convert Type
		public static implicit operator int (LimitedInt li)
		{
			return li.TheValue;
		}

		// Convert Type
		public static implicit operator LimitedInt(int x)
		{
			LimitedInt li = new LimitedInt();
			li.TheValue = x;
			return li;
		} 
	}
}