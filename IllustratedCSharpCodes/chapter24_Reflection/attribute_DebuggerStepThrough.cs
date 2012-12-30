using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; // Required for this DebuggerStepThrough.

namespace Reflection
{
    class Program
    {
		private int _x = 1;
		public int X
		{
			get 
			{ 
				return _x; 
			}
			[DebuggerStepThrough]	// Don't step through the set accessor.
			set 
			{ 
				_x = _x * 2;
				_x = value;
			}
		}
		public int Y
		{
			get;
			set;
		}

		[DebuggerStepThrough] // Don't step through this method.
		private void IncrementFields()
		{
			X++;
			Y++;
		}

        static void Main(string[] args)
        {
			Program p = new Program();
			p.IncrementFields();
			p.X = 5;
			Console.WriteLine("X = {0}, Y = {1}", p.X, p.Y);
		}
	}
}