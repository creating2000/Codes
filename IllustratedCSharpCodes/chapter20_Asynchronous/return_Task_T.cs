using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
	static class DoAsyncStuff
	{
		// Return type: Task<T>	
		public static async Task<int> CalculateSumAsync(int i1, int i2)
		{
			int sum = await Task.Run(() => GetSum(i1, i2));
			return sum;
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
			Task<int> sum = DoAsyncStuff.CalculateSumAsync(5, 6);
			// Do other processing...
			Console.WriteLine("Sum: {0}", sum.Result);
		}
	}
}