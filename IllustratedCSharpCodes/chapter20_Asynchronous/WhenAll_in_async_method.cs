using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Asynchronous
{
	class MyDownloadString
	{
		public void DoRun()
		{
			Task<int> task = CountCharacterTaskAsync("http://www.microsoft.com", "http://www.illustratedcsharp.com");
			Console.WriteLine("DoRun: Task {0}finished", task.IsCompleted ? "" : "not ");
			Console.WriteLine("DoRun: Result = {0}", task.Result);
		}

		private async Task<int> CountCharacterTaskAsync(string site1, string site2)
		{
			WebClient wc1 = new WebClient();
			WebClient wc2 = new WebClient();

			Task<string> task1 = wc1.DownloadStringTaskAsync(new Uri(site1));
			Task<string> task2 = wc2.DownloadStringTaskAsync(new Uri(site2));
			// List<Task<string>> taskList = new List<Task<string>>[] { task1, task2 };
			List<Task<string>> taskList = new List<Task<string>> ();
			taskList.Add(task1);
			taskList.Add(task2);

			// await Task.WhenAll(taskList);
			await Task.WhenAny(taskList);

			Console.WriteLine("		CCA: task1 {0}finished.", task1.IsCompleted ? "" : "not ");
			Console.WriteLine("		CCA: task2 {0}finished.", task2.IsCompleted ? "" : "not ");

			return task1.IsCompleted ? task1.Result.Length : task2.Result.Length;
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