using System;
namespace learnCSharpBasics.Generic
{
	class Person
	{
        public string Name { set; get; } = "unknown";
        public int Age { set; get; } = 0;

        public virtual void SayHello()
        {
            Console.WriteLine($"Hi, My name is {Name}");
        }
    }
	class Student : Person
	{
		
	}

	class Teacher : Person
	{
        public override void SayHello()
        {
			Console.WriteLine($"Hi, My name is {Name}, I'm {Age} years old");
        }
    }

	class PersonWithCloth<T> where T : Person
	{
		public PersonWithCloth(T person)
		{
			Person = person;
		}
		public T Person { get; set; }
		public string ClothColor { get; set; } = "unknown";
	}

	public class GenericConstrains
	{
		public static void run()
		{
			Student student = new Student { Name = "sean", Age = 30 };
			student.SayHello();
			Teacher teacher = new Teacher { Name = "ellen", Age = 18 };
			teacher.SayHello();
			var p1 = new PersonWithCloth<Student>(student) { ClothColor = "red" };
		}
	}
}

