using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
	class MyClass
	{
		public int Get10()
		{
			return 10;
		}
		public async Task DoAsyncWork()
		{
			Func<int> ten = new Func<int>(Get10);
			int a = await Task.Run(ten);

			int b = await Task.Run(new Func<int>(Get10));

			int c = await Task.Run(() => { return 10; });
			Console.WriteLine("a: {0}, b: {1}, c: {2}", a, b, c);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Task task = (new MyClass()).DoAsyncWork();
			task.Wait();
			Console.WriteLine("Program Exit!");
		}
	}
}