using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
			using (TextWriter tw1 = File.CreateText("nestusing1.txt"))
			{
				tw1.WriteLine("hello, jack!--kate");
				using (TextWriter tw2 = File.CreateText("nestusing2.txt"))
				{
					tw2.WriteLine("early to bed, early to rise.");
				}
			}

			using (TextReader tr1 = File.OpenText("nestusing1.txt"))
			{
				string inputString = string.Empty;
				while ((inputString = tr1.ReadLine()) != null)
				{
					Console.WriteLine(inputString);
				}
				
				using (TextReader tr2 = File.OpenText("nestusing2.txt"))
				{
					while ((inputString = tr2.ReadLine()) != null)
					{
						Console.WriteLine(inputString);
					}
				}
			}
		}
	}
}