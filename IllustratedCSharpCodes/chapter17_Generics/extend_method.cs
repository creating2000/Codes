using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	// static method in static class.
	static class ExtendHolder
	{
		// Do not forget : this.
		public static void Print<T> (this Holder<T> h)
		{
			T[] vals = h.GetValues();
			Console.WriteLine("{0},\t{1},\t{2}", vals[0], vals[1], vals[2]);
		}
	}

	class Holder<T>
	{
		T[] Vals = new T[3];
		public Holder(T v0, T v1, T v2)
		{
			Vals[0] = v0;
			Vals[1] = v1;
			Vals[2] = v2;
		}

		public T[] GetValues()
		{
			return Vals;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			var intHolder = new Holder<int> ( 1, 3, 5 );
			var stringHolder = new Holder<string>( "a1", "b2", "c3" );

			intHolder.Print();
			stringHolder.Print();
		}
	}
}