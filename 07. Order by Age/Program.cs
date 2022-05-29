using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] personInfo = input.Split();
                people.Add(new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2])));
                input = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            Id = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        //Stefan with ID: 524244 is 10 years old.
        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
