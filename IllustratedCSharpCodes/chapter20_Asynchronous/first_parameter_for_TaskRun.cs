using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
	static class MyClass
	{
		public static async Task DoAsyncStuff()
		{
			// delegate signature
			// void Action()
			await Task.Run(() => Console.WriteLine(5.ToString())); // await expression as a statement.
			// TResult Func()
			Console.WriteLine((await Task.Run(() => 6)).ToString());// as a parameter.
			// Task Func()
			await Task.Run(() => Task.Run(() => Console.WriteLine(7.ToString())));// as a statement.
			// Task<TResult> Func()
			// 1.
			Console.WriteLine((await Task.Run(() => Task.Run(() => 8))));// as a parameter.
			// 2.
			int value = await Task.Run(() => Task.Run(() => 8));// as right-hand side of an assignment
			Console.WriteLine(value);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Task task = MyClass.DoAsyncStuff();
			task.Wait();
			Console.WriteLine("Press Enter key to exit!");
			Console.Read();
		}
	}
}