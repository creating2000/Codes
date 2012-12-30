using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
	struct MyStruct
	{
		public int X;
		public int Y;
		public MyStruct(int xVal, int yVal)
		{
			X = xVal;
			Y = yVal;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyStruct mSStruct = new MyStruct(12, 13);
			MyStruct? mSNull = new MyStruct(10, 10);
			
			// Struct access directly
			Console.WriteLine("mSStruct.X : {0}", mSStruct.X);
			Console.WriteLine("mSStruct.Y : {0}", mSStruct.Y);

			// Nullable type access from Value 
			Console.WriteLine("mSNull.X : {0}", mSNull.Value.X);
			Console.WriteLine("mSNull.Y : {0}", mSNull.Value.Y);
		}
	}
}