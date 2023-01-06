using System;
namespace learnCSharpBasics
{
	public class IsOperator
	{
		public static void run()
		{
            object b = new Base();
            Console.WriteLine(b is Base);
            Console.WriteLine(b is Derived);

            object d = new Derived();
            Console.WriteLine(d is Base);
            Console.WriteLine(d is Derived);

            int i = 27;
            // output `true`, because int32 implemented IFormattable interface
            Console.WriteLine(i is System.IFormattable);

            object iBoxed = i;
            Console.WriteLine(iBoxed is int);
            Console.WriteLine(iBoxed is long);

            i = 23;
            iBoxed = i;
            int? jNullable = 7;
            if (iBoxed is int a && jNullable is int c)
            {
                Console.WriteLine(a + c);
            }
        }
	}
}

