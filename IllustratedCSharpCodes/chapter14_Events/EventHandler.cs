using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
	class Incrementer
	{
		public event EventHandler CountedADozen;// Use the system-defined Eventhandler delegate

		public void DoCount()
		{
			for (int i = 1; i < 100; i++)
			{
				if (i % 12 == 0 && CountedADozen != null)
				{
					CountedADozen(this, null); // Use EventHandler's parameters when raising the event.
				}
			}
		}
	}

	class Dozens
	{
		public int DozensCount
		{
			get;
			private set;
		}
		// The signature of the event handler must match that of the delegate.
		void IncrementDozensCount(object source, EventArgs e)
		{
			DozensCount++;
		}
		
		
		public Dozens(Incrementer incrementer)
		{
			DozensCount = 0;
			incrementer.CountedADozen += IncrementDozensCount;// Subscribe to the event.
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Incrementer incrementer = new Incrementer();
			Dozens dozens = new Dozens(incrementer); 

			incrementer.DoCount();
			Console.WriteLine("Number of dozens = {0}", dozens.DozensCount);
		}
	}
}