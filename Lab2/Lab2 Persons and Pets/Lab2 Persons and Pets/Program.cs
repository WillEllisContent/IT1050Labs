using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person();
            A.firstname = "Bob";
            A.lastname = "Jones";

            Person B = new Person();
            B.firstname = "Frank";
            B.lastname = "Smith";

            Pet C = new Pet();
            C.petname = "Fido";
            C.petage = 5;
            C.petspecies = "Dog";
            C.petowner = A.fullname();

            Pet D = new Pet();
            D.petname = "Mr. Fluffy";
            D.petage = 12;
            D.petspecies = "Cat";
            D.petowner = B.fullname();

            Pet E = new Pet();
            E.petname = "Puffball";
            E.petage = 1;
            E.petspecies = "Hamster";
            E.petowner = B.fullname();

            Console.WriteLine("First Pet:");
            Console.WriteLine(C.petname);
            Console.WriteLine(C.petage + " years old");
            Console.WriteLine(C.petspecies);
            Console.WriteLine(C.petowner);
            Console.WriteLine();
            Console.WriteLine("Second Pet:");
            Console.WriteLine(D.petname);
            Console.WriteLine(D.petage + " years old");
            Console.WriteLine(D.petspecies);
            Console.WriteLine(D.petowner);
            Console.WriteLine();
            Console.WriteLine("Third Pet:");
            Console.WriteLine(E.petname);
            Console.WriteLine(E.petage + " year old");
            Console.WriteLine(E.petspecies);
            Console.WriteLine(E.petowner);
            Console.ReadLine();
        }
    }
}

