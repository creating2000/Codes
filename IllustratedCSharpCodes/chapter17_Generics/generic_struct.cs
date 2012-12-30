using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	// Generic struct.
	struct PieceOfData<T>
	{
		private T _data;
		public T Data
		{
			get 
			{ 
				return _data; 
			}
			set 
			{ 
				_data = value; 
			}
		}

		public PieceOfData(T value)
		{
			_data = value;
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			// After new: Constructed type.
			var intData = new PieceOfData<int> (10);
			var stringData = new PieceOfData<string> ("hello");

			Console.WriteLine("intData: {0}", intData.Data);
			Console.WriteLine("stringData: {0}", stringData.Data);
		}
	}
}