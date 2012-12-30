using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
		static async Task BadAsync()
		{
			try
			{
				await Task.Run(() => { throw new Exception();});
			}
			catch
			{
				Console.WriteLine("Exception in BadAsync!");
			}
		}

        static void Main(string[] args)
        {
			Task task = BadAsync();
			task.Wait();
			Console.WriteLine("Task Status: {0}", task.Status);
			Console.WriteLine("Task IsFaulted: {0}", task.IsFaulted);
		}
	}
}