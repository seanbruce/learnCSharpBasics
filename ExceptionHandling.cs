using System;
namespace learnCSharpBasics
{
	public class ExceptionHandling
	{
		class CustomException : Exception
		{
			public CustomException(string message) : base(message) { }
		}

        private static void TestThrow()
        {
            throw new CustomException("Custom exception in TestThrow()");
        }

        private static void MethodThatTestNull(Person p)
        {
            _ = p ?? throw new ArgumentException("Parameter cannot be null", nameof(p));
        }

        public static void run()
		{
            try
			{
				TestThrow();
			} catch (CustomException ex)
			{
                System.Console.WriteLine(ex.ToString());
            }

            try
            {
                using (var sw = new StreamWriter("./test.txt"))
                {
                    sw.WriteLine("Hello");
                }
            }
            // Put the more specific exceptions first.
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            // Put the least specific exception last.
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Done");
        }
	}
}

