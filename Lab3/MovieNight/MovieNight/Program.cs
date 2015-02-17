using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Are you going to a Matinee or an Evening show?");
            string MovieType = Console.ReadLine();

            Console.WriteLine("You selected " + MovieType + ".");
            Console.ReadLine();

            Console.Write("How many full-price adults?");
            int Adults = int.Parse(Console.ReadLine());

            Console.Write("How many children?");
            int Children = int.Parse(Console.ReadLine());

            Console.Write("How many senior citizens?");
            int Seniors = int.Parse(Console.ReadLine());


        }
    }
}
