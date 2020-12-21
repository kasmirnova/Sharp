using System;
using System.Collections.Generic;

namespace lb11_2
{
    public static class Extension
    {
        public static List<Student> FindStudents(this List<Student> students, Student.StudentPredicateDelegate studentPredicate)
        {
            List<Student> finish = new List<Student>();

            foreach (var student in students)
            {
                if (studentPredicate(student))
                    finish.Add(student);
            }
            return finish;
        }
    }

    public class Student
    {
        public delegate bool StudentPredicateDelegate(Student student);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static bool Adult(Student student) { return student.Age >= 18; }
        public static bool CheckFirstName(Student student) { return student.FirstName?[0] == 'A'; }
        public static bool CheckLastName(Student student) { return student.LastName?.Length > 3; } 
        public override string ToString()
        {
            return
              $"First name: {FirstName}\n" +
              $"Last name: {LastName}\n" +
              $"Age: {Age}\n";
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int number = 14;
            List<Student> students = new List<Student>();
            List<Student> studentsTemp = new List<Student>();
            Random random = new Random();


            for (int i = 0; i < number; i++)
            {
                Student student = new Student();
                student.FirstName = RandomFN(random);
                student.LastName = RandomLN(random);
                student.Age = random.Next(10, 30);
                students.Add(student);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Number of Student:");
            Console.WriteLine(number);
            Console.WriteLine();
            foreach (var student in students)
                Console.WriteLine(student);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nStudents over 18\n");
            studentsTemp = students.FindStudents(Student.Adult);
            foreach (var student in studentsTemp)
                Console.WriteLine(student + " ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nStudents whose name begins with \'A\':\n");
            studentsTemp = students.FindStudents(Student.CheckFirstName);
            foreach (var student in studentsTemp)
                Console.WriteLine(student + " ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nStudents whose last name is more than 3 characters:\n");
            studentsTemp = students.FindStudents(Student.CheckLastName);
            foreach (var student in studentsTemp)
                Console.WriteLine(student + " ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nStudents over 18:\n");
            studentsTemp = students.FindStudents(s => s.Age >= 18);
            foreach (var student in studentsTemp)
                Console.WriteLine(student + " ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nStudents whose name begins with \'A\':\n");
            studentsTemp = students.FindStudents(s => s.FirstName?[0] == 'A');
            foreach (var student in studentsTemp)
                Console.WriteLine(student + " ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nStudents whose last name is more than 3 characters:\n");
            studentsTemp = students.FindStudents(s => s.LastName?.Length > 3);
            foreach (var student in studentsTemp)
                Console.WriteLine(student + " ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nStudents from 20 to 25 years old: \n");
            studentsTemp = students.FindStudents(s => s.Age >= 20 && s.Age <= 25);
            foreach (var student in studentsTemp)
                Console.WriteLine(student + " ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nStudents with the name Kate:\n");
            studentsTemp = students.FindStudents(s => s.FirstName.Equals("Kate"));
            foreach (var student in studentsTemp)
                Console.WriteLine(student + " ");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("\nStudents with the last name Black: \n");
            studentsTemp = students.FindStudents(s => s.LastName.Equals("Black"));
            foreach (var student in studentsTemp)
                Console.WriteLine(student + " ");
            Console.WriteLine();
            Console.ReadKey();

        }

        public static string RandomFN(Random random)
        {
            string[] FN = new string[]
            {
                "Kate",
                "Olia",
                "Yulia",
                "Nastya",
                "Max",
                "Alex",
                "Misha",
                "Albert",
                "Vadim",
                "Bogdan"
            };
            return FN[random.Next(FN.Length)];
        }
        public static string RandomLN(Random random)
        {
            string[] LN = new string[]
               {
                "Smyrnova",
                "Fedorova",
                "Black",
                "Amosova",
                "Durnev",
                "Black",
                "Artemenko",
                "Novikov",
                "Nazarov",
                "Martinuk"
               };
            return LN[random.Next(LN.Length)];
        }
    }
}
