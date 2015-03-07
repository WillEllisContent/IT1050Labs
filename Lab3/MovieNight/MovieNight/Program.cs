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
            // need to declare certain variables here //
            int FreePopcorn = 0;
            int FreeCandy = 0;
            double TotalTicketPrice = 0;
            
            Console.WriteLine("Are you going to a Matinee or an Evening show?");
            Console.WriteLine("1. Matinee");
            Console.WriteLine("2. Evening");

            Console.WriteLine("Press 1 or 2");
            int MovieType = int.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine("You selected " + MovieType + ".");
            Console.WriteLine();

            Console.Write("How many full-price adults?");
            int Adults = int.Parse(Console.ReadLine());

            Console.Write("How many children?");
            int Children = int.Parse(Console.ReadLine());

            Console.Write("How many senior citizens?");
            int Seniors = int.Parse(Console.ReadLine());
            int TotalNumberTickets = Adults + Children + Seniors;


            if (MovieType == 1)
            {
                double AdultsTickets = Adults * 5.99;
                double ChildrenTickets = Children * 3.99;
                double SeniorsTickets = Seniors * 4.50;
                TotalTicketPrice = AdultsTickets + ChildrenTickets + SeniorsTickets;
                Console.WriteLine("Your total ticket price is $" + TotalTicketPrice);
            }
            else if (MovieType == 2)
            {
                double AdultsTickets = Adults * 10.99;
                double ChildrenTickets = Children * 6.99;
                double SeniorsTickets = Seniors * 8.50;
                TotalTicketPrice = AdultsTickets + ChildrenTickets + SeniorsTickets;
                Console.WriteLine("Your total ticket price is $" + TotalTicketPrice);
                if (TotalNumberTickets >= 3) ;
                {
                    Console.WriteLine("You get a free popcorn!");
                    FreePopcorn = 1;
                }

            }

                
                

            //Now for the Snacks//
                Console.WriteLine();
                Console.WriteLine("Snacks Menu:");
                Console.WriteLine("Small Soda $3.50");
                Console.WriteLine("Large Soda $5.99");
                Console.WriteLine("Hot Dog $3.99");
                Console.WriteLine("Popcorn $4.50");
                Console.WriteLine("Candy $1.99 - buy 3, get 1 free");
                Console.WriteLine();

                Console.WriteLine("How many small sodas?");
                int SmallSoda = int.Parse(Console.ReadLine());
                Console.WriteLine("How many large sodas?");
                int LargeSoda = int.Parse(Console.ReadLine());
                Console.WriteLine("How many hot dogs?");
                int HotDog = int.Parse(Console.ReadLine());
                Console.WriteLine("How many popcorns?");
                int Popcorn = int.Parse(Console.ReadLine());
                Console.WriteLine("How many packs of candy?");
                int Candy = int.Parse(Console.ReadLine());

                if (Popcorn >= 1 && LargeSoda >= 1)
                {
                    TotalTicketPrice = TotalTicketPrice - 2;
                }

// buy 3 candy get 1 free //
             

                double SmallSodaPrice = SmallSoda * 3.5;
                double LargeSodaPrice = LargeSoda * 5.99;
                double HotDogPrice = HotDog * 3.99;
                double PopcornPrice = Popcorn * 4.5;
                double CandyPrice = Candy * 1.99;

                double TotalSnackPrice = SmallSodaPrice + LargeSodaPrice + HotDogPrice + PopcornPrice + CandyPrice;

                Console.WriteLine("Your total snack price is $" + TotalSnackPrice + ".");

                double TotalPrice = TotalSnackPrice + TotalTicketPrice;
                Console.WriteLine("Your total for the trip to the movies is $" + TotalPrice + ".");
                Console.ReadLine();



       }   
    }
}

