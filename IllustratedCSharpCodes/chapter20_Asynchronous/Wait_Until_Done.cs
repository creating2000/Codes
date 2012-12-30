using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // For Thread.Sleep()

namespace Asynchronous
{
	delegate long MyDel(int first, int second);	// Declare delegate type.

    class Program
    {
		static long Sum(int first, int second)		// Declare method for async.
		{
			Console.WriteLine("			Inside Sum");
			Thread.Sleep(3000);
			return first + second;
		}

        static void Main(string[] args)
        {
			MyDel del = new MyDel(Sum);

			Console.WriteLine("Before BeginInvoke");
			IAsyncResult iar = del.BeginInvoke(8, 9, null, null);	// Start async
			Console.WriteLine("After BeginInvoke");

			Console.WriteLine("Doing Stuff...");
			
			long result = del.EndInvoke(iar);	// Wait for end and get result.
			Console.WriteLine("After EndInvoke {0}", result);
		}
	}
}