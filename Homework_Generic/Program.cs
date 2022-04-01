﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Homework_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1.3 Program class
            //a) 4 dənə student obyekti yaradın qarışıq point dəyərlərində.
            //b) Group obyekti yaradın və group obyektinə AddStudent methodundan istifadə edərək studentləri əlavə edin.
            //c) GetAllStudents methodundan istifadə edərək bütün studentləri ekrana çıxardın.
            //d) Sort methodundan istifadə edərək sort olunmuş studentləri ekrana çıxardın.
            //e) İkinci bir Group obyketi yaradın və qrup nömrəsinin avtomatik artmağını yoxlayın.


            Student student = new Student("Sahil", "Mamedov", 25, 100);
            Student student2 = new Student("Efqan", "Hesenov", 27, 42);
            Student student3 = new Student("Orxan", "Salmanov", 25, 60);
            Student student4 = new Student("Afet", "Salmanova", 25, 33);
            Group group = new Group();
            group.AddStudent(student);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);
            group.GetAllStudents();
            group.Sort();



        }
    }
}