using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?"); // prompt user for first name
            string firstName = Console.ReadLine(); 
            Console.WriteLine("What is your middle initial?"); //prompt user for middle initial
            char middleInitial = Console.ReadKey().KeyChar;
            Console.WriteLine("What is your last name?"); //prompt user for last name
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + middleInitial + ". " + lastName;
            
            Console.WriteLine("How old are you?"); //prompt user for age
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("How many feet tall are you?"); //prompt user for height in feet
            int heightFeet = int.Parse(Console.ReadLine());
            Console.WriteLine("How many inches?"); //prompt user for inches
            double heightInches = double.Parse(Console.ReadLine());
            double totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            bool isCitizen = true;
            bool canVote = isCitizen && age >= 18;

            Console.WriteLine(fullName);
            Console.WriteLine(totalHeightCM);
            Console.WriteLine(canVote);
        }
    }
}
