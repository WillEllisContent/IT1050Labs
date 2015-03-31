using System;

namespace Lab4
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public bool Married;
        public int SpouseAge;

        public static Person Create(string Person)
        {
            Person person = new Person();
            Console.WriteLine(Person);
            string FirstName = Question.AskForString("First Name");
            string LastName = Question.AskForString("Last Name");
            int Age = Question.AskForInteger("Age");
            bool Married = Question.AskForBoolean("Married");
            if (Married)
            {
                Person Spouse = new Person();
                string SpouseName = Question.AskForString("Spouse Name");
                int SpouseAge = Question.AskForInteger("Spouse Age");

            }
            Console.WriteLine();
            return person;
        }
    }
}