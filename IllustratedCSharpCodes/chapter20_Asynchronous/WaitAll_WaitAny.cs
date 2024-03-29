using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;

namespace Asynchronous
{
	class MyDownloadString
	{
		Stopwatch sw = new Stopwatch();
		public void DoRun()
		{
			sw.Start();
			Task<int> t1 = CountCharactersAsync( 1, "http://www.microsoft.com" );
			Task<int> t2 = CountCharactersAsync( 2, "http://www.illustratedcsharp.com" );
			Task<int>[] tasks = new Task<int>[] { t1, t2 };
			Task.WaitAll( tasks );
			//Task.WaitAny( tasks );
			Console.WriteLine( "Task 1: {0}Finished", t1.IsCompleted ? "" : "Not " );
			Console.WriteLine( "Task 2: {0}Finished", t2.IsCompleted ? "" : "Not " );
			Console.Read();
		}

		private async Task<int> CountCharactersAsync( int id, string site )
		{
			WebClient wc = new WebClient();
			string result = await wc.DownloadStringTaskAsync( new Uri( site ) );
			Console.WriteLine( " Call {0} completed: {1, 4:N0} ms", id, sw.Elapsed.TotalMilliseconds );
			return result.Length;
		}
}

    class Program
    {
        static void Main(string[] args)
        {
			MyDownloadString mds = new MyDownloadString();
			mds.DoRun();
		}
	}
}