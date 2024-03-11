using System;
namespace immutableID
{
    class Student
    {
        public record studentInfo
        {

            // auto-implemented properties
            public int Id { get; init; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // default constructor
            public studentInfo()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }
            // parameterized constructor
            public studentInfo(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }
            public studentInfo(int i)
            {
                Id = i;
                FirstName = "";
                LastName = "";
            }

        }
        public static void Main()
        {
            studentInfo student1 = new(1);
            Console.WriteLine("What is your first name?");
            student1.FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            student1.LastName = Console.ReadLine();
            Console.WriteLine(student1);

            studentInfo student2 = new(2, "Scooby", "Doo");
            Console.WriteLine(student2);
        }

    }
}
