using System;
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
                    Console.Write("Student ID#: ");
                    Students[i].StudentNumber = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
                Console.WriteLine("Summary");
                Console.WriteLine("Course Name: " + CourseName);
                Console.WriteLine("Course Number: " + CourseNumber);
                Console.WriteLine("Students:");

                for (i = 0; i < StudentBase; i++)
                {
                    
                    Console.WriteLine(Students[i].StudentName);
                    Console.WriteLine(Students[i].StudentNumber);
                }

                Console.WriteLine();
                Console.WriteLine("Is everything correct? Enter y or n");
                Answer = Console.ReadLine();
             }



                Console.ReadLine();
        }
    }
}
