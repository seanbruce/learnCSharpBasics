using System;
namespace learnCSharpBasics
{
	public class AsOperator
	{
		public static void run()
		{
			IEnumerable<int> numbers = new[] { 10, 20, 30 };
			// why a value of IEnumerable type can be converted to IList type
			IList<int>? indexable = numbers as IList<int>;
			if (indexable != null)
			{
				Console.WriteLine(indexable[0] + indexable[indexable.Count - 1]);
			}
		}
	}
}

