using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterators
{
	class Spectrum // Not enumerable : it doesn't implement GetEnumerator
	{
		private string[] _colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red"};

		// Returns an enumerable.
		public IEnumerable<string> UV2IR()
		{
			for (int i = 0; i < _colors.Length; i++)
			{
				yield return _colors[i];
			}
		}

		// Returns an enumerable.
		public IEnumerable<string> IR2UV()
		{
			for (int i = _colors.Length - 1; i >= 0 ; i--)
			{
				yield return _colors[i];
			}
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Spectrum s = new Spectrum();
			foreach (string item in s.UV2IR())
			{
				Console.Write(item + "\t");
			}

			Console.WriteLine();

			foreach (string item in s.IR2UV())
			{
				Console.Write(item + "\t");
			}
		}
	}
}