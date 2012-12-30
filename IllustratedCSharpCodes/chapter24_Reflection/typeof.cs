using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection; // must use it

namespace Reflection
{
	class BaseClass
	{
		public int MyFieldBase = 0;
	}
	class DerivedClass : BaseClass
	{
		public int MyFieldDerived = 0;
	}

    class Program
    {
        static void Main(string[] args)
        {
			Type tbc = typeof(DerivedClass);		
			Console.WriteLine("Result is {0}.", tbc.Name);

			Console.WriteLine("It has the following fields: ");
			FieldInfo[] fi = tbc.GetFields();
			foreach (var f in fi)
			{
				Console.WriteLine("			{0}", f.Name);
			}
		}
	}
}