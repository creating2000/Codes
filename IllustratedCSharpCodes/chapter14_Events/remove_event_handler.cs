using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
	class Publisher
	{
		public event EventHandler SimpleEvent;
		public void RaiseTheEvent()
		{
			SimpleEvent(this, null);
		}

	}

	class Subscriber
	{
		public void MethodA(object o, EventArgs e)
		{
			Console.WriteLine("AAA");
		}
		public void MethodB(object o, EventArgs e)
		{
			Console.WriteLine("BBB");
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Publisher p = new Publisher();
			Subscriber s = new Subscriber();

			p.SimpleEvent += s.MethodA;
			p.SimpleEvent += s.MethodB;
			p.RaiseTheEvent();

			p.SimpleEvent -= s.MethodB;
			p.RaiseTheEvent();
		}
	}
}