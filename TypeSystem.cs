using System;
namespace learnCSharpBasics.LearnTypeSystem;

class Person {
    public string FullName { get; set; } = "unknown";
}

record Teacher (string FirstName, string LastName);

record TeacherWithPhone (string FirstName, string LastName, string[] PhoneNumbers) : Teacher(FirstName, LastName);

record TeacherWithInit (string FirstName, string LastName): Teacher(FirstName, LastName)
{
    public string[]? PhoneNumbers { get; init; }
}

interface IPlayable
{
    bool isGameOver { get; }
    
}

public class TypeSystem
{
    public static void run()
    {
        int a = 5;
        int b = a + 3;

        //bool b1 = true;

        // Operator '+' cannot be applied to operands of type 'bool' and 'int'
        // int c = b1 + a;

        // In C#, bool is not convertible to int

        // auto boxing
        //Console.WriteLine(String.Concat("Answer", 42, true));

        Person person = new Person();
        //Console.WriteLine(person.FullName);

        Teacher teacher = new("Tom", "Cluize");
        //Console.WriteLine(teacher);

        string[] phoneNumbers = new string[2];
        TeacherWithPhone teacher2 = new("sean", "S", phoneNumbers);
        TeacherWithPhone teacher3 = new("sean", "S", phoneNumbers);
        //Console.WriteLine(teacher2 == teacher3);

        teacher2.PhoneNumbers[0] = "555-1234";
        //Console.WriteLine(teacher2 == teacher3);

        //Console.WriteLine(ReferenceEquals(teacher2, teacher3));

        TeacherWithInit teacher4 = new("james", "bond") { PhoneNumbers = new string[1] };
        Console.WriteLine(teacher4);

        TeacherWithInit teacher5 = teacher4 with { FirstName = "John" };
        Console.WriteLine(teacher5);
        Console.WriteLine(teacher4 == teacher5);
    }
}


