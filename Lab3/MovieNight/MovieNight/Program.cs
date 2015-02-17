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

            Console.WriteLine();

            Console.WriteLine("You selected " + MovieType + ".");
            Console.WriteLine();

            Console.Write("How many full-price adults?");
            double Adults = double.Parse(Console.ReadLine());

            Console.Write("How many children?");
            double Children = double.Parse(Console.ReadLine());

            Console.Write("How many senior citizens?");
            double Seniors = double.Parse(Console.ReadLine());

            if (MovieType == "Matinee")
            {
                double AdultsTickets = Adults * 5.99;
                double ChildrenTickets = Children * 3.99;
                double SeniorsTickets = Seniors * 4.50;
                double TotalTicketPrice = AdultsTickets + ChildrenTickets + SeniorsTickets;
                Console.WriteLine("Your total ticket price is $" + TotalTicketPrice);
                Console.ReadLine();
            }
            else if (MovieType == "Evening")
            {
                double AdultsTickets = Adults * 10.99;
                double ChildrenTickets = Children * 6.99;
                double SeniorsTickets = Seniors * 8.50;
                double TotalTicketPrice = AdultsTickets + ChildrenTickets + SeniorsTickets;
                Console.WriteLine("Your total ticket price is $" + TotalTicketPrice);
                Console.ReadLine();
            }



        }   
    }
}
