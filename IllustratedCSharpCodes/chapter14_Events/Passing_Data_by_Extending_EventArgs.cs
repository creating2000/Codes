using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
	public class IncrementerEventArgs : EventArgs
	{
		public int IterationCount
		{
			get;
			set;
		}
	}
	class Incrementer
	{
		// Generic delegate using custom class.
		public event EventHandler<IncrementerEventArgs> CountedADozen;

		public void DoCount()
		{
			// Object of custom class.
			IncrementerEventArgs args = new IncrementerEventArgs();

			for (int i = 1; i < 100; i++)
			{
				args.IterationCount = i;

				if (i % 12 == 0 && CountedADozen != null)
				{
					// Pass parameters when raising the event.
					CountedADozen(this, args);
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
		void IncrementDozensCount(object source, IncrementerEventArgs e)
		{
			Console.WriteLine("Incremented at iteration: {0} in {1}", e.IterationCount, source.ToString());
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