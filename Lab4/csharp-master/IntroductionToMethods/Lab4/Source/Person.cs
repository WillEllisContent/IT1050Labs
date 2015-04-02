﻿using System;

namespace Lab4
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public bool Married;
        

        public static Person Create(string PersonNumber)
        {
            Person person = new Person();
            Question.SetPromptPrefix(PersonNumber);
            person.FirstName = Question.AskForString("First Name");
            person.LastName = Question.AskForString("Last Name");
            person.Age = Question.AskForInteger("Age");
            person.Married = Question.AskForBoolean("Married");
            if (person.Married)
            {
                Person Spouse = new Person();
                Spouse.FirstName = Question.AskForString("Spouse Name");
                Spouse.LastName = person.LastName;
                Spouse.Age = Question.AskForInteger("Spouse Age");
                Spouse.Married = true;
                Spouse.Spouse = person;
            }
            Console.WriteLine();
            return person;
        }
    }
}