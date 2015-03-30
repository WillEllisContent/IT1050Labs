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

        public static Person Create(string Person)
        {
            Person person = new Person();
            string firstName;
            string lastName;
            int age;
            bool married;
            firstName = Question.AskForString("First Name");
            lastName = Question.AskForString("Last Name");
            age = Question.AskForInteger("Age");
            married = Question.AskForBoolean("Married");
            if (married)
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