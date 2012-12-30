using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	// Generic interface.
	interface IMyIfc<T>
	{
		T ReturnIt (T inValue);
	}

	// Nongeneric class
	class Simple : IMyIfc<int>, IMyIfc<string>
	{
		// Implement interface using int.
		public int ReturnIt(int inValue)
		{
			return inValue;
		}
		// Implement interface using string.
		public string ReturnIt(string inValue)
		{
			return inValue;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			var trivial = new Simple();
			
			Console.WriteLine(trivial.ReturnIt(100));
			Console.WriteLine(trivial.ReturnIt("jack"));
		}
	}
}