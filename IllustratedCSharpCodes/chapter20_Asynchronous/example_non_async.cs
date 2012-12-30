using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;// new add
using System.Net;

namespace Asynchronous
{
	class MyDownloadString
	{
		Stopwatch sw = new Stopwatch();
		public void DoRun() 
		{
			const int largeNumber = 6000000;
			sw.Start();

			int t1 = CountCharacters(1, "http://www.microsoft.com");
			int t2 = CountCharacters(2, "http://www.illustratedcsharp.com");

			CountToALargeNumber(1, largeNumber);
			CountToALargeNumber(2, largeNumber);
			CountToALargeNumber(3, largeNumber);
			CountToALargeNumber(4, largeNumber);

			Console.WriteLine("Characters in http://www.microsoft.com		 : {0}", t1);
			Console.WriteLine("Characters in http://www.illustratedcsharp.com: {0}", t2);
		}

		private int CountCharacters(int id, string uriString)
		{
			WebClient wc = new WebClient();
			Console.WriteLine("Starting call {0}  :    {1, 4:N0}ms", id, sw.Elapsed.TotalMilliseconds);
			string result = wc.DownloadString(new Uri(uriString));
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