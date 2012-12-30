using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	interface IDataStore
	{
		void SetData(int data);
	}

	interface IDataRetrive
	{
		int GetData();
	}

	// Derives from the first two interfaces.
	interface IDataIO : IDataStore, IDataRetrive
	{
		// Contain all the members!
	}

	class MyData : IDataIO
	{
		private int _data;
		public void SetData(int data)
		{
			_data = data;
		}
		public int GetData()
		{
			return _data;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyData md = new MyData();
			md.SetData(999);
			Console.WriteLine(md.GetData());
		}
	}
}