using System;

namespace Homework_Generic
{
    public class Student
    {



        public int Id { get; set; }
        private static int _id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }
        public Student(string name, string surname, int age, int point)
        {
            _id++;
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
            Id = _id;
        }

        public static bool operator >(Student s1, Student s2)
        {
            return (s1.Point > s2.Point);
        }
        public static bool operator <(Student s1, Student s2)
        {
            return (s1.Point < s2.Point);

        }



        public void ShowInfo()
        {
            Console.WriteLine($"Id student:{Id}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nPoint:{Point}");
        }

    }
}
