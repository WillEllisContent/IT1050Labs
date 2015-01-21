using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Will";
            char middleInitial = 'M' ;
            string lastName = "Ellis";
            string fullName = firstName + " " + middleInitial + ". " + lastName;

            int age = 36;
            int heightFeet = 5;
            double heightInches = 8;
            double totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            bool isCitizen = true;
            bool canVote = isCitizen && age >= 18;

            Console.WriteLine(fullName);
            Console.WriteLine(totalHeightCM);
            Console.WriteLine(canVote);
        }
    }
}
