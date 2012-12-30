using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    class Program
    {
        static void Main(string[] args)
        {
			string parseResultSummary = string.Empty;
			string stringFirst = "28";
			int intFirst = 0;
			//							intput string, output variable
			bool isSuccess = int.TryParse(stringFirst, out intFirst);
			parseResultSummary = isSuccess ? "was successfully parsed" : "was not successfully parsed";
			Console.WriteLine("String {0} {1}", stringFirst, parseResultSummary);

			string stringSecond = "heloo89";
			int intSecond = 0;

			isSuccess = int.TryParse(stringSecond, out intSecond);
			parseResultSummary = isSuccess ? "was successfully parsed" : "was not successfully parsed";
			Console.WriteLine("String {0}, {1}", stringSecond, parseResultSummary);
		}
	}
}