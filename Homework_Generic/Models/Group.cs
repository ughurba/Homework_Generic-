using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_Generic
{
    public class Group
    {


        List<Student> students = new List<Student>();
        private static int CurrentId = 100;
        public string GroupNo { get; }
        public Group()
        {

            GroupNo = $"AP{CurrentId++}";

            Console.WriteLine(GroupNo);

        }


        public void AddStudent(Student stu)
        {
            students.Add(stu);
        }

        public void GetAllStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Student Id:{student.Id}\nName:{student.Name}\nSurname:{student.Surname}\nAge:{student.Age}\nPoint:{student.Point}");
                Console.WriteLine();
                Console.WriteLine();
            }

        }

        public List<Student> Sort()
        {

            List<Student> SortedList = students.OrderBy(x => x.Point).ToList();
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Sort Point");
            Console.WriteLine();
            foreach (Student student in SortedList)
            {

                Console.WriteLine($"Student Id:{student.Id}\nName:{student.Name}\nSurname:{student.Surname}\nAge:{student.Age}\nPoint:{student.Point}");
                Console.WriteLine();
                Console.WriteLine();
            }
            return SortedList;
        }

    }
}
