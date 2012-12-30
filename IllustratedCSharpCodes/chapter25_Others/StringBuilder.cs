using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // need this

namespace OtherTopics
{
    class Program
    {
        static void Main(string[] args)
        {
			StringBuilder sb = new StringBuilder("hi, there!");
			Console.WriteLine(sb.ToString()); // Print string.
			sb.Replace("hi", "jack");			// Replace a substring.
			Console.WriteLine(sb.ToString());   // Print changed string.
		}
	}
}