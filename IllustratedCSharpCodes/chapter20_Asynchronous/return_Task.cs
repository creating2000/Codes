using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
	static class DoAsyncStuff
	{
		public static async Task CalculateSumAsync(int i1, int i2)
		{
			int sum = await Task.Run(() => GetSum(i1, i2)); 
			Console.WriteLine("Sum: {0}", sum);
			// No return statement.
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
			Task someTask = DoAsyncStuff.CalculateSumAsync(5, 6);
			// Do other processing...
			someTask.Wait();
			Console.WriteLine("Async stuff is done!");
		}
	}
}