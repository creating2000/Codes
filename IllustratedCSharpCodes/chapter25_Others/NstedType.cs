using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
	class SomeClass							// Enclosing class
	{
		private int _field1 = 17;			// Fields of enclosing class.
		private int _field2 = 18;
		
		MyNested mn = null;					// Reference to nested class.
		
		public SomeClass()					// Constructor.
		{
			// Pass in the reference to the enclosing class.
			mn = new MyNested(this);		// Create instance of nested class.
		}

		public void PrintMyMembers()					
		{
			mn.PrintOuterMembers();			// Call method in nested class.
		}

		class MyNested						// Nested class declaration.
		{
			SomeClass _sc = null;			// Reference to enclosing class.

			public MyNested(SomeClass sc)	// Constructor of the nested class.
			{
				_sc = sc;					// Store reference to enclosing class.
			}

			public void PrintOuterMembers()
			{
				Console.WriteLine("Field1 : {0}", _sc._field1); // Enclosing field.
				Console.WriteLine("Field2 : {0}", _sc._field2);
			}
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			SomeClass sc = new SomeClass();
			sc.PrintMyMembers();
		}
	}
}