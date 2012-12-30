using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Asynchronous
{
	delegate long MyDel(int first, int second);

    class Program
    {
		static long Sum(int x, int y)
		{
			Console.WriteLine("			Inside Sum");
			Thread.Sleep(30);
			return x + y;
		}

        static void Main(string[] args)
        {
			MyDel del = new MyDel(Sum);	

			IAsyncResult iar = del.BeginInvoke(11, 12, null, null);
			Console.WriteLine("After BeginInvoke");
			
			// Check whether the asynchronous method is done.
			while (!iar.IsCompleted)
			{
				Console.WriteLine(" Not Done");
				for (int i = 0; i < 10000000; i++)
				{
					// Continue processing, even though in this case it's just busywork.
				}
			}
			Console.WriteLine("Done");
			long result = del.EndInvoke(iar); // Call EndInvoke to get result and clean up.
			Console.WriteLine("Result: {0}", result);
		}
	}
}