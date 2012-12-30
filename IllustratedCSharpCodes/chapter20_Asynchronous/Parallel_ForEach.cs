using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] squares = new string[] { "We", "hold", "these", "truths", "to", "be", "self-evident", "that", "all", "men", "are", "created", "equal"};
			// static ParallelLoopResult ForEach<TSource> ( IEnumerable<TSource> source, Action<TSource> body)
			// TSource is the type of object in the collection.
			// source is the collection of TSource objects.
			// body is the lambda expression to be applied to each element of the collection.
			Parallel.ForEach(squares, i => Console.WriteLine(string.Format("{0} has {1} letters", i, i.Length)));
		}
	}
}