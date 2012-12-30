using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;// Use the Reflection namespace to take full advantage
						// of determining information about a type.

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
			Type t = typeof(SomeClass);

			FieldInfo[] fi = t.GetFields();
			MethodInfo[] mi = t.GetMethods();

			foreach (FieldInfo f in fi)
			{
				Console.WriteLine(f.Name);
			}
			foreach (MethodInfo m in mi)
			{
				Console.WriteLine(m.Name);
			}
		}
	}

	class SomeClass
	{
		public int Field1;
		public int Field2;

		public void Method1() {}
		public int Method2() {return 1;}
	}
}