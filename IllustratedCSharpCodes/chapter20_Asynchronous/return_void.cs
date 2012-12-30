using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous
{
	static class DoAsyncStuff
	{
		// Return void: fire-and-forget
		public static async void CalculateSumAsync(int i1, int i2)
		{
			int sum = await Task.Run(() => GetSum(i1, i2));
			Console.WriteLine("Sum: {0}", sum);
		}
		private static int GetSum(int i1, int i2)
		{
			return i1 + i2;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			DoAsyncStuff.CalculateSumAsync(5, 6);
			// Do other processing...
			Thread.Sleep(2000);
			Console.WriteLine("Program Exiting!");
		}
	}
}