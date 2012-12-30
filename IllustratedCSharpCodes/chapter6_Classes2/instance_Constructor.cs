using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
	class Class1
	{
		int Id;
		string Name;
		
		// Constructors
		public Class1()
		{
			Id = 18;
			Name = "Nemo";
		}

		public Class1(int Val)
		{
			Id = Val;
			Name = "Nemo";
		}

		public Class1(string name)
		{
			Name = name;
		}

		public void SoundOff()
		{
			Console.WriteLine("Name: {0}, Id: {1}", this.Name, this.Id);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Class1 a = new Class1(),
				   b = new Class1(7),
				   c = new Class1("Jack");
			// Call constructors
			a.SoundOff();
			b.SoundOff();
			c.SoundOff();
		}
	}
}