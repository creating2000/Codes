using System;

namespace Delegates
{
	delegate double MyDel(int par);

	class Program
	{
		static void Main()
		{
			MyDel myDel = delegate (int x)				// Anonymous method
			{
				return x + 1;
			};							

			MyDel md1 =		(int x) => {return x + 1;};	// Lambda expression
			MyDel md2 =		(	x)	=> {return x + 1;};				
			MyDel md3 =			x	=> {return x + 1;};
			MyDel md4 =			x	=>		   x + 1;

			Console.WriteLine(myDel(12));

			Console.WriteLine(md1(12));
			Console.WriteLine(md2(12));
			Console.WriteLine(md3(12));
			Console.WriteLine(md4(12));
			string str = Console.ReadLine();
			Console.WriteLine(str);
		}
	}
}