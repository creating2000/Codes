using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;// new add
using System.Net;
using System.Threading.Tasks;

namespace Asynchronous
{
	class MyDownloadString
	{
		Stopwatch sw = new Stopwatch();
		public void DoRun() 
		{
			const int largeNumber = 6000000;
			sw.Start();
			// Task<int> t1 : Objects that will hold the results.
			Task<int> t1 = CountCharactersAsync(1, "http://www.microsoft.com");
			Task<int> t2 = CountCharactersAsync(2, "http://www.illustratedcsharp.com");

			CountToALargeNumber(1, largeNumber);
			CountToALargeNumber(2, largeNumber);
			CountToALargeNumber(3, largeNumber);
			CountToALargeNumber(4, largeNumber);
			// t1.Result: Get results.
			Console.WriteLine("Characters in http://www.microsoft.com		 : {0}", t1.Result);
			Console.WriteLine("Characters in http://www.illustratedcsharp.com: {0}", t2.Result);
		}

		// async: Contextual keyword
		// Task<int>: Type that represents work being done, which will eventually return an int
		private async Task<int> CountCharactersAsync(int id, string uriString)
		{
			WebClient wc = new WebClient();
			Console.WriteLine("Starting call {0}  :    {1, 4:N0}ms", id, sw.Elapsed.TotalMilliseconds);
			// await: Contextual keyword
			string result = await wc.DownloadStringTaskAsync(new Uri(uriString));
			Console.WriteLine("    Call {0} completed:    {1, 4:N0}ms", id, sw.Elapsed.TotalMilliseconds);
			return result.Length;
		}

		private void CountToALargeNumber(int id, int number)
		{
			for (int i = 0; i < number; i++)
			{
				// nothing here.
			}
			Console.WriteLine("    End counting {0}  :    {1, 4:N0}ms", id, sw.Elapsed.TotalMilliseconds);
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			MyDownloadString mc = new MyDownloadString();
			mc.DoRun();
		}
	}
}