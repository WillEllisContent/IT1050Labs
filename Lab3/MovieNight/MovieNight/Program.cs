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
            double AdultsTickets = 0.00;
            double ChildrenTickets = 0.00;
            double SeniorsTickets = 0.00;
            int FreePopcorn = 0;
            int FreeCandy = 0;
            int FreeCandyTotal = 0;
            double TotalTicketPrice = 0;
            
            Console.WriteLine("Are you going to a Matinee or an Evening show?");
            Console.WriteLine("1. Matinee");
            Console.WriteLine("2. Evening");

            Console.WriteLine("Press 1 or 2");
            int MovieType = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("You selected " + MovieType + ".");
            Console.WriteLine();

            Console.Write("How many full-price adults? ");
            int Adults = int.Parse(Console.ReadLine());

            Console.Write("How many children? ");
            int Children = int.Parse(Console.ReadLine());

            Console.Write("How many senior citizens? ");
            int Seniors = int.Parse(Console.ReadLine());
            int TotalNumberTickets = Adults + Children + Seniors;


            if (MovieType == 1)
            {
                AdultsTickets = Adults * 5.99;
                ChildrenTickets = Children * 3.99;
                SeniorsTickets = Seniors * 4.50;
                TotalTicketPrice = AdultsTickets + ChildrenTickets + SeniorsTickets;
                Console.WriteLine("Your total ticket price is $" + TotalTicketPrice);
            }
            else if (MovieType == 2)
            {
                AdultsTickets = Adults * 10.99;
                ChildrenTickets = Children * 6.99;
                SeniorsTickets = Seniors * 8.50;
                TotalTicketPrice = AdultsTickets + ChildrenTickets + SeniorsTickets;
                //evening show popcorn promo//
                if (TotalNumberTickets >= 3)
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

                Console.Write("How many small sodas? ");
                int SmallSoda = int.Parse(Console.ReadLine());
                Console.Write("How many large sodas? ");
                int LargeSoda = int.Parse(Console.ReadLine());
                Console.Write("How many hot dogs? ");
                int HotDog = int.Parse(Console.ReadLine());
                Console.Write("How many popcorns? ");
                int Popcorn = int.Parse(Console.ReadLine());
                Console.Write("How many packs of candy? ");
                int Candy = int.Parse(Console.ReadLine());

                //large soda and popcorn promo//
                if (Popcorn >= 1 && LargeSoda >= 1)
                {
                    TotalTicketPrice = TotalTicketPrice - 2;
                    Console.WriteLine("You have earned a $2 discount on your ticket price!");
                    Console.WriteLine();
                }

                // buy 3 candy get 1 free //

                FreeCandy = Candy;

                for (int FreeCandies = 0; FreeCandy >= 3; FreeCandies++)
                {
                    Console.WriteLine("You get a free candy!");
                    FreeCandy = FreeCandy - 3;
                    FreeCandyTotal++;
                }
                
                double SmallSodaPrice = SmallSoda * 3.5;
                double LargeSodaPrice = LargeSoda * 5.99;
                double HotDogPrice = HotDog * 3.99;
                double PopcornPrice = Popcorn * 4.5;
                double CandyPrice = Candy * 1.99;

                double TotalSnackPrice = SmallSodaPrice + LargeSodaPrice + HotDogPrice + PopcornPrice + CandyPrice;

                // Lets do a summary //
                Console.WriteLine();
                Console.WriteLine("Summary: ");
                Console.WriteLine();
                if (MovieType == 1)
                {
                    Console.WriteLine("Matinee");
                }

                else
                {
                    Console.WriteLine("Evening");
                }
                Console.WriteLine("Adult tickets: " + Adults + " = $" + AdultsTickets);
                Console.WriteLine("Child tickets: " + Children + " = $" + ChildrenTickets);
                Console.WriteLine("Senior tickets: " + Seniors + " = $" + SeniorsTickets);
                Console.WriteLine();
                Console.WriteLine("Snacks: ");
                Console.WriteLine("Small Sodas: " + SmallSoda + " = $" + SmallSodaPrice);
                Console.WriteLine("Large Sodas: " + LargeSoda + " = $" + LargeSodaPrice);
                Console.WriteLine("Hot Dogs: " + HotDog + " = $" + HotDogPrice);
                Console.WriteLine("Popcorn: " + Popcorn + " + " + FreePopcorn +" free" + " = $"+ PopcornPrice);
                Console.WriteLine("Candy: " + Candy + " + " + FreeCandyTotal +" free" + " = $"+ CandyPrice);
                Console.WriteLine();
                Console.WriteLine("Your total ticket price is $" + TotalTicketPrice);
                Console.WriteLine("Your total snack price is $" + TotalSnackPrice + ".");


                double TotalPrice = TotalSnackPrice + TotalTicketPrice;
                Console.WriteLine("Your total for the trip to the movies is $" + TotalPrice + ".");
                Console.ReadLine();



       }   
    }
}

