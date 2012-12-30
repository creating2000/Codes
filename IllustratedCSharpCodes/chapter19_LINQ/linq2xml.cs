using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
			XDocument xd = XDocument.Load("SimpleSample.xml");
			XElement rt = xd.Root;

			var query = from item in rt.Elements()
						where item.Name.ToString().Length == 5
						select item;
			foreach (var q in query)
			{
				Console.WriteLine(q.Name.ToString());
			}

			Console.WriteLine();

			foreach (var q in query)
			{
				Console.WriteLine("Name: {0}, color: {1}, size: {2}",
									q.Name, 
									q.Attribute("color").Value,
									q.Attribute("size").Value);
			}
		}
	}
}