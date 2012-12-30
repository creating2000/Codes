using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
	static class MyClass
	{
		public static int GetSum(int i1, int i2)
		{
			return i1 + i2;
		}

		public static async Task DoWorkAsync()
		{
			// match TResult Func()
			int sum = await Task.Run(() => GetSum(5, 6));
			Console.WriteLine(sum);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Task task = MyClass.DoWorkAsync();
			task.Wait();
			Console.WriteLine("Press Enter key!");
			Console.Read();
		}
	}
}