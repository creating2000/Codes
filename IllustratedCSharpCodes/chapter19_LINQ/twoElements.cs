using System;
using System.Xml.Linq;		// This namespace is required

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
			XDocument employeeDoc = new XDocument(		// Create the document.
				new XElement("Employees",				// Create the root element.
					new XElement("Employee",			// First employee element.
						new XElement("Name", "Bob"),
						new XElement("PhoneNumber", "123123123")),
					new XElement("Employee",			// Second employee element.
						new XElement("Name", "Jack"),
						new XElement("PhoneNumber", "34234"),
						new XElement("PhoneNumber", "23434")
					)
				)	
			);

			Console.WriteLine(employeeDoc);				// Displays the document.
		}
	}
}