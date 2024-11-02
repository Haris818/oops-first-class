using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Classes
{
    class Human
    {
        public string Name;
        public int Age;
        public long Phone; 
        public string Gender;

        public void Run()
        {
            Console.WriteLine($"HELLO, MY NAME IS {Name} AND I AM RUNNING");
        }

        public void Details()
        {
            Console.WriteLine($"HELLO, MY NAME IS {Name}, MY AGE IS {Age}, " +
                              $"MY CONTACT NUMBER IS {Phone}, AND I AM {Gender}");
        }
    }

    class Student : Human
    {
        public string SchoolName;

        public void Study()
        {
            Console.WriteLine($"{Name} is studying at {SchoolName}.");
        }
    }

    class Teacher : Human
    {
        public string Subject;

        public void Teach()
        {
            Console.WriteLine($"{Name} teaches {Subject}.");
        }
    }

    class Athlete : Human
    {
        public string Sport;

        public void Compete()
        {
            Console.WriteLine($"{Name} is competing in {Sport}.");
        }
    }

    class Engineer : Human
    {
        public string Field;

        public void Work()
        {
            Console.WriteLine($"{Name} works in the field of {Field}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student
            {
                Name = "HARIS",
                Age = 18,
                Phone = 1234567890,
                Gender = "MALE",
                SchoolName = "KARACHI University"
            };
            student.Details();
            student.Study();

            Teacher teacher = new Teacher
            {
                Name = "HARIS",
                Age = 18,
                Phone = 9876543210,
                Gender = "MALE",
                Subject = "Mathematics"
            };
            teacher.Details();
            teacher.Teach();

            Athlete athlete = new Athlete
            {
                Name = "HARIS",
                Age = 18,
                Phone = 1122334455,
                Gender = "MALE",
                Sport = "Football"
            };
            athlete.Details();
            athlete.Compete();

            Engineer engineer = new Engineer
            {
                Name = "HARIS",
                Age = 18,
                Phone = 5566778899,
                Gender = "MALE",
                Field = "Software Engineering"
            };
            engineer.Details();
            engineer.Work();

            Console.ReadKey();
        }
    }
}
