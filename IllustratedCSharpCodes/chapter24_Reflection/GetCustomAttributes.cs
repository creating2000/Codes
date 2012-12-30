using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Class)]
	public sealed class ReviewCommentAttribute : System.Attribute
	{ 
		public string Description { get; set; }
		public string VersionNumber { get; set; }
		public string ReviewerID { get; set; }

		public ReviewCommentAttribute(string desc, string ver)
		{
			Description = desc;
			VersionNumber = ver;
		}
	}

	[ReviewComment("Check it out", "2.4")]
	class MyClass { }

	class Program
	{
		static void Main(string[] args)
		{
			MyClass mc = new MyClass(); // Create an instance of the class.
			Type t = mc.GetType(); // Get the Type object from the instance.

			// IsDefined
			bool isDefined = // Check the Type for the attribute.
			t.IsDefined(typeof(ReviewCommentAttribute), false);
			if( isDefined )
			{
				Console.WriteLine("ReviewComment is applied to type {0}", t.Name);
			}
			
			// GetCustomAttributes
			object[] AttArr = t.GetCustomAttributes( false );
			foreach ( Attribute a in AttArr )
			{
				ReviewCommentAttribute attr = a as ReviewCommentAttribute;
				if ( null != attr )
				{
					Console.WriteLine( "Description : {0}", attr.Description );
					Console.WriteLine( "Version Number : {0}", attr.VersionNumber );
					Console.WriteLine( "Reviewer ID : {0}", attr.ReviewerID );
				}
			}
		}
	}
}