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
						select new { item.Name, color = item.Attribute("color")};
			foreach (var q in query)
			{
				Console.WriteLine(q);
			}

			Console.WriteLine();
			foreach (var q in query)
			{
				Console.WriteLine("{0, -6}, color: {0, -7}", q.Name, q.color.Value);
			}
		}
	}
}