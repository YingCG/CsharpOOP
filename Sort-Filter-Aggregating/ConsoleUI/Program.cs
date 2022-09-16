using System;
using System.Collections.Generic;
using System.Linq;
using LinqLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            //people = people.OrderBy(x => x.FirstName).ToList();
            //people = people.OrderByDescending(x => x.FirstName).ThenBy(x => x.Birthday).ToList();
            //people = people.Where(x => x.YearsExperience > 9 && x.Birthday.Month == 2).ToList();
            people = people.Where(x => x.YearsExperience > 9).ToList();


            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString() }) : Experience {person.YearsExperience}");
            }

            int yearsTotal = 0;
            yearsTotal = people.Sum(x => x.YearsExperience);

            Console.WriteLine($"The total years experience of people is {yearsTotal}");

            Console.ReadLine();
        }
    }
}
