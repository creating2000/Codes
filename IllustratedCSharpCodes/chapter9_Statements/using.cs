using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // using directive

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
			// using statement
			using (TextWriter tw = File.CreateText("hello.txt"))
			{
				tw.WriteLine("Hello, Jack! Where are we?");
			}

			// using statement
			using (TextReader tr = File.OpenText("hello.txt"))
			{
				string inputString = string.Empty;
				while ((inputString = tr.ReadLine()) != null)
				{
					Console.WriteLine(inputString);
				}
			}
		}
	}
}