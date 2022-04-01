using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_Generic
{
    public class Group
    {
        List<Student> students = new List<Student>();

        public Group()
        {

            //string str = "AP101";
            //string digits = new string(str.Where(char.IsDigit).ToArray());
            //string letters = new string(str.Where(char.IsLetter).ToArray());
            //int num;
            //int.TryParse(digits, out num);
            //num++;
            //digits = Convert.ToString(num);
            //letters = letters + digits;



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
