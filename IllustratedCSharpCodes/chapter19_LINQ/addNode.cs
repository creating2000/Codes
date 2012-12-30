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
			XDocument xd = new XDocument(		// Create XML tree.
				new XElement("root", 
					new XElement("first")
				)	
			);
			Console.WriteLine(xd);				// Display the tree.
			Console.WriteLine();

///			XElement rt = xd.Element("root");
			XElement rt = xd.Root;				// Get the first element.
			rt.AddFirst(new XElement("second"));		// Add a child element.
			rt.AddFirst(								// Add three more children.
				new XElement("third"),	
				new XComment("Important Comment"),
				new XElement("fourth")
			);
				rt.Add(new XElement("fifth"));
				rt.AddFirst(new XElement("sixth"));

			Console.WriteLine("Modified tree: ");	// Display modified tree.
			Console.WriteLine(xd);
		}
	}
}