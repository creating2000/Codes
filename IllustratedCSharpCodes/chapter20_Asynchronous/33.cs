using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous
{
	class MyClass
	{
		public async Task RunAsync(CancellationToken token)
		{
			if (token.IsCancellationRequested)
			{
				return;
			}
			await Task.Run(() => CycleMethod(token), token);
		}

		public void CycleMethod(CancellationToken token)
		{
			Console.WriteLine("Starting CycleMethod:");
			const int max = 5;
			for (int i = 0; i < max; i++)
			{
				if (token.IsCancellationRequested)
				{
					return;
				}
				Thread.Sleep(1000);
				Console.WriteLine("{0} of {1} iterations completed!", i + 1, max);
			}
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			CancellationTokenSource cts = new CancellationTokenSource();
			CancellationToken token = cts.Token;

			MyClass mc = new MyClass();
			Task task = mc.RunAsync(token);
			
			Thread.Sleep(3000);
			cts.Cancel();

			task.Wait();
			Console.WriteLine("Was Cancelled: {0}", token.IsCancellationRequested);
		}
	}
}