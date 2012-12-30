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
			using (TextWriter tw1 = File.CreateText("txt1.txt"),
							  tw2 = File.CreateText("txt2.txt"))	
			{
				tw1.WriteLine("hello, Early to bed");
				tw2.WriteLine("hi, Early to rise");
			}

			using (TextReader tr1 = File.OpenText("txt1.txt"),
							  tr2 = File.OpenText("txt2.txt"))
			{
				string inputString = string.Empty;
				while ((inputString = tr1.ReadLine()) != null)
				{
					Console.WriteLine(inputString);
				}

				while ((inputString = tr2.ReadLine()) != null)
				{
					Console.WriteLine(inputString);
				}
			}
		}
	}
}