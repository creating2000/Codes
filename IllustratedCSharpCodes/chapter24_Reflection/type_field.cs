using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
	class BaseClass
	{
		public int BaseField = 0;
	}

	class DerivedClass : BaseClass
	{
		public int DerivedField = 0;
	}

    class Program
    {
        static void Main(string[] args)
        {
			BaseClass bc = new BaseClass();
			DerivedClass dc = new DerivedClass();

			BaseClass[] bca = new BaseClass[] { bc, dc };
			foreach (var item in bca)
			{
				Type t = item.GetType(); // Get the type.
				Console.WriteLine("Object type: {0}", t.Name);

				FieldInfo[] fi = t.GetFields();// Get the field information.
				foreach (var f in fi)
				{
					Console.WriteLine("			Field: {0}", f.Name);
				}
			}
		}
	}
}