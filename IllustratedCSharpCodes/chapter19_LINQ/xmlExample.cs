using System;
using System.Xml.Linq;	// Required namespace

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
			XDocument employees1 = new XDocument(	// Create the XML document.
				new XElement("Employees",			// Create the root element.
					new XElement("Name", "Bob"),		// Create element.
					new XElement("Name", "Jack")		// Create element.
				)	
			);

			employees1.Save("EmployeesFile.xml");		// Save to a file.

			XDocument employees2 = XDocument.Load("EmployeesFile.xml"); // Static method.
			Console.WriteLine(employees2);	// Display document
		}
	}
}