using System;
namespace learnCSharpBasics
{
    public class AttributeInCS
    {
        [Serializable]
        [Author("P. Ackerman", Version = 1.1)]
        [Author("R. Koch", Version = 1.1)]
        class Person {}

        [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct, AllowMultiple = true)]
        public class AuthorAttribute : System.Attribute
        {
            private string _name;
            public double Version;

            public AuthorAttribute(string name)
            {
                _name = name;
                Version = 1.0;
            }

            public string GetName()
            {
                return _name;
            }
        }

        private static void PrintAuthorInfo(System.Type t)
        {
            Console.WriteLine("Author information for {0}", t);

            // Using reflection.  
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is AuthorAttribute)
                {
                    AuthorAttribute a = (AuthorAttribute)attr;
                    System.Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.Version);
                }
            }
        }

        public static void run()
        {
            PrintAuthorInfo(typeof(Person));
        }
    }
}

