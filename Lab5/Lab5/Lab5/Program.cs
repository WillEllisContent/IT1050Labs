﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Answer = "n";
            while (Answer == "n")
            {

                Course course = new Course();
                Console.WriteLine("Enter the name of the course: ");
                string CourseName = Console.ReadLine();
                Console.WriteLine("Enter the course number: ");
                int CourseNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("How many students are taking the course");
                int StudentBase = int.Parse(Console.ReadLine());
                Student[] Students = new Student[StudentBase];
                int i;

                for (i = 0; i < StudentBase; i++)
                {
                    Students[i] = new Student();
                    Console.Write("Student Name: ");
                    Students[i].StudentName = Console.ReadLine();
                }

                Console.WriteLine(CourseName);
                Console.WriteLine(CourseNumber);
                Console.WriteLine(Students);
                Console.WriteLine("Is everything correct? Enter y or n");
                Answer = Console.ReadLine();
             }



                Console.ReadLine();
        }
    }
}
