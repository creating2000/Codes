using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
			XDocument xd = new XDocument(
				new XDeclaration("1.0", "utf-8", "yes"),// It's included in the document file, Console.WriteLine() cannot show it
				new XComment("This is a comment"),
				new XProcessingInstruction("xml-stylesheet", @"href=""stories.css"" type=""text/css"""),
				new XElement("root", 
					new XAttribute("color", "red"),
					new XAttribute("size", "large"),
					new XElement("first"),
					new XElement("second")
				)	
			);
			Console.WriteLine(xd);
			Console.WriteLine();

			

///			XElement rt = xd.Element("root");
			XElement rt = xd.Root;						// Get the element.
			XAttribute color = rt.Attribute("color");	// Get the attribute.
			XAttribute size = rt.Attribute("size");		// Get the attribute.

			Console.WriteLine("color is {0}", color.Value);// Display attr.value.
			Console.WriteLine("size is {0}", size.Value);
			Console.WriteLine();

			rt.SetAttributeValue("color", "blue");	// Change a attribute value
			rt.SetAttributeValue("width", "narrow");// Add a attribute
			Console.WriteLine(xd);
			Console.WriteLine();

			rt.Attribute("color").Remove();		// Remove the color attribute
			Console.WriteLine(xd);
			Console.WriteLine();
			rt.SetAttributeValue("size", null);// Remove the size attribute
			Console.WriteLine(xd);
		}
	}
}