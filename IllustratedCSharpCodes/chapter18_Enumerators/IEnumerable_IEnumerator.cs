using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Enumerators
{
	class ColorEnumerator : IEnumerator
	{
		string[] _colors;
		int _position = -1;
		// Constructor
		public ColorEnumerator(string[] theColors)
		{
			_colors = new string[theColors.Length];
			for (int i = 0; i < theColors.Length; i++)
			{
				_colors[i] = theColors[i];
			}
		}
		
		// Implement Current.(read only, return object)
		public object Current
		{
			get 
			{ 
				if (_position == -1)
				{
					throw new InvalidOperationException();
				}
				if (_position >= _colors.Length)
				{
					throw new InvalidOperationException();
				}
				return _colors[_position]; 
			}
		}
		
		// Implement MoveNext().
		public bool MoveNext()
		{
			if (_position < _colors.Length - 1)
			{
				_position++;
				return true;
			}
			else 
			{
				return false;
			}
		}

		// Implement Reset().
		public void Reset()
		{
			_position = -1;
		}

	}

	class Spectrum : IEnumerable
	{
		string[] Colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red"};
		public IEnumerator GetEnumerator()
		{
			return new ColorEnumerator(Colors);
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			Spectrum spectrum = new Spectrum();
			foreach (string color in spectrum)
			{
				Console.WriteLine(color);
			}
		}
	}
}