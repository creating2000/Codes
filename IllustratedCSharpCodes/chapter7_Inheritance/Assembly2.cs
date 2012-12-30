using System;
using BaseClassNS; // miss an assembly reference

namespace UseBaseClass
{
	class DerivedClass : MyBaseClass
	{
		//Empty body
	}

	class Program
	{
		static void Main()
		{
			DerivedClass mdc = new DerivedClass();
			mdc.PrintMe();
		}
	}
}