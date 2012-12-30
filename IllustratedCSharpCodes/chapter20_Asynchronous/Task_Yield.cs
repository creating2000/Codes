using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
	static class DoStuff
	{
		public static async Task<int> FindSeriesSum(int count)	
		{
			int sum = 0;
			for (int i = 0; i < count; i++)
			{
				sum += i;
				if (count % 1000 == 0)
				{
					await Task.Yield();
				}
			}
			return sum;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Task<int> value = DoStuff.FindSeriesSum(1000000);
			CountBig(100000);
			CountBig(100000);
			CountBig(100000);
			CountBig(100000);
			Console.WriteLine("Sum: {0}", value.Result);
		}

		private static void CountBig(int bigNumber)
		{
			for (int i = 0; i < bigNumber; i++)
			{
				;
			}
		}
	}
}