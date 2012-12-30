using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging; // 
using System.Threading;		//

namespace Asynchronous
{
	delegate long MyDel(int first, int second);

    class Program
    {
		static long Sum(int x, int y)
		{
			Console.WriteLine("			Inside Sum");
			Thread.Sleep(100);
			return x + y;
		}

		static void CallWhenDone(IAsyncResult iar)
		{
			Console.WriteLine("			Inside CallWhenDone");
			AsyncResult ar = (AsyncResult) iar;
			MyDel del = (MyDel) ar.AsyncDelegate;

			long result = del.EndInvoke(iar);
			Console.WriteLine("			The result is {0}", result);
		}

        static void Main(string[] args)
        {
			MyDel del = new MyDel(Sum);

			Console.WriteLine("Before BeginInvoke");
			IAsyncResult iar = del.BeginInvoke(10, 10, new AsyncCallback(CallWhenDone), null);
			
			Console.WriteLine("Doing more work in Main");
			Thread.Sleep(3000);
			Console.WriteLine("Done with Main. Exiting.");
		}
	}
}