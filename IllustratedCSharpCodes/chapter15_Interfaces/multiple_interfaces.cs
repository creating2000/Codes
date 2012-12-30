using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	interface IDataRetrive			// Declare interface.
	{
		int GetData();
	}
	interface IDataStore			// Declare interface.
	{
		void SetData(int data);
	}

	class MyData					// Declare class.
	{
		private int _value;			// Declare field.
		public int GetData()
		{
			return _value;
		}
		public void SetData(int data)
		{
			_value = data;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyData md = new MyData();
			md.SetData(52991314);
			Console.WriteLine(md.GetData());
		}
	}
}