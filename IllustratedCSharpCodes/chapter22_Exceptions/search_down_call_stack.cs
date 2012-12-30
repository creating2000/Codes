using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
	class MyClass 
	{
		public void A()
		{
			try
			{
				B();
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("catch clause in A()");
			}
			finally
			{
				Console.WriteLine("finally clause in A()");
			}
		}

		private void B()
		{
			int x  = 10, y = 0;
			try
			{
				x /= y;
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("catch clause in B()");
			}
			finally
			{
				Console.WriteLine("finally clause in B()");
			}
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			MyClass mc = new MyClass();
			try
			{
				mc.A();
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("catch clause in Main()");
			}
			finally
			{
				Console.WriteLine("finally clause in Main()");
			}

			Console.WriteLine("After try statement in Main.");
			Console.WriteLine(" -- Keep running.");
		}
	}
}