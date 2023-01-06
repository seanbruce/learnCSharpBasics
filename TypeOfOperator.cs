using System;
namespace learnCSharpBasics
{
	public class Animal { }
	public class Giraffe : Animal { }

	public class TypeOfOperator
	{
		public static void run()
		{
			void PrintType<T>() => Console.WriteLine(typeof(T));

			Console.WriteLine(typeof(List<string>));
			PrintType<int>();
			PrintType<System.Int32>();
			PrintType<Dictionary<int, char>>();

			object b = new Giraffe();
			Console.WriteLine(b is Animal); // true
			Console.WriteLine(b.GetType() == typeof(Animal)); // false

			Console.WriteLine(b is Giraffe); // true
			Console.WriteLine(b.GetType() == typeof(Giraffe)); // true
		}
	}
}

