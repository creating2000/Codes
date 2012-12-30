using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;// new 

namespace Asynchronous
{
	class Simple
	{
		Stopwatch sw = new Stopwatch();
		public void DoRun()
		{
			Console.WriteLine( "Caller: Before call" );
			ShowDelayAsync();
			Console.WriteLine( "Caller: After call" );
		}

		private async void ShowDelayAsync ( )
		{
			sw.Start();
			Console.WriteLine( " Before Delay: {0}", sw.ElapsedMilliseconds );
			await Task.Delay( 1000 );
			Console.WriteLine( " After Delay : {0}", sw.ElapsedMilliseconds );
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Simple s = new Simple();
			s.DoRun();
			Console.Read();// need cmd.exe
		}
	}
}
