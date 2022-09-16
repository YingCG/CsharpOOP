using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLibrary
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> sampleData = new List<Person>();

            sampleData.Add(new Person { FirstName = "Tim", LastName = "Corey", Birthday = Convert.ToDateTime("25/2/1999"), YearsExperience = 10 });
            sampleData.Add(new Person { FirstName = "Someone", LastName = "Nice", Birthday = Convert.ToDateTime("12/5/1995"), YearsExperience = 16 });
            sampleData.Add(new Person { FirstName = "Another", LastName = "Kind people", Birthday = Convert.ToDateTime("7/12/1983"), YearsExperience = 1 });
            sampleData.Add(new Person { FirstName = "One", LastName = "Ohter Kind", Birthday = Convert.ToDateTime("2/2/1970"), YearsExperience = 5 });
            sampleData.Add(new Person { FirstName = "Some", LastName = "Lovely human", Birthday = Convert.ToDateTime("9/7/1980"), YearsExperience = 7 });
            
            return sampleData;
        }
    }
}
