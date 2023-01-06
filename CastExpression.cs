using System;
namespace learnCSharpBasics
{
	public class CastExpression
	{
		public static void run()
		{
			double x = 1234.7;
			int a = (int)x;
			Console.WriteLine(a);

			IEnumerable<int> numbers = new int[] { 10, 20, 30 };
			IList<int> list = (IList<int>)numbers;
			Console.WriteLine(list.Count);
			Console.WriteLine(list[1]);
		}
	}
}

