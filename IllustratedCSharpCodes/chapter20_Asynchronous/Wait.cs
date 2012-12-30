using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Asynchronous
{
	static class MyDownloadString
	{
		public static void DoRun()
		{
			Task<int> task = CountCharactersAsync("http://www.illustratedcsharp.com");
			task.Wait();// Wait until Task task completes.
			Console.WriteLine("The task has finished, returning value: {0}", task.Result);
		}

		static async Task<int> CountCharactersAsync(string site)
		{
			string result = await new WebClient().DownloadStringTaskAsync(new Uri(site));
			return result.Length;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyDownloadString.DoRun();
		}
	}
}