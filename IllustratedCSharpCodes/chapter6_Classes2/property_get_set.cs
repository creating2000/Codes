using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class C1
	{
		private int theRealValue;		// Backing Field: memory allocated
		public int MyValue				// Property: no memory allocated
		{
			set
			{
				theRealValue = value;	// Sets the value of field TheRealValue
			}
			get
			{
				return theRealValue;	// Gets the value of the field
			}
		}

	}

    class Program
    {
        static void Main(string[] args)
        {
			C1 c = new C1();
			Console.WriteLine("MyValue: {0}", c.MyValue);// Read from the property as if it were a field
			
			c.MyValue = 20;	// Use assignment to set the value of a property
			Console.WriteLine("MyValue: {0}", c.MyValue);
			
		}
	}
}