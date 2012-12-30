using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
	// 1. Declare the delegate.
	delegate void Handler();

	// Publisher
	class Incrementer
	{
		// 2. Create and publish an event.
		public event Handler CountedADozen;

			//public static event EventHandler CountedADozen;
			// public event EventHandler MyEvent1, MyEvent2, OtherEvent;

		public void DoCount()
		{
			for (int i = 1; i < 100; i++)
			{
				if (i % 12 == 0 && CountedADozen != null)
				{
					CountedADozen(); // 5. Raise the event every 12 counts.
				}
			}
		}
	}

	// Subscriber
	class Dozens
	{
		public int DozensCount
		{
			get;
			private set;
		}

		// 3. Declare the event handler.
		void IncrementDozensCount()
		{
			DozensCount++;
		}
		
		
		public Dozens(Incrementer incrementer)
		{
			DozensCount = 0;
			incrementer.CountedADozen += IncrementDozensCount;// 4. Subscribe to the event.
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