using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LinqLibrary
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> sampleData = new List<Person>();

            var nzCulture = CultureInfo.GetCultureInfo("en-NZ");

            sampleData.Add(new Person { FirstName = "Tim", LastName = "Corey", Birthday = Convert.ToDateTime("25/02/1999", nzCulture), YearsExperience = 10 });
            sampleData.Add(new Person { FirstName = "Someone", LastName = "Nice", Birthday = Convert.ToDateTime("12/05/1995", nzCulture), YearsExperience = 16 });
            sampleData.Add(new Person { FirstName = "Another", LastName = "Kind people", Birthday = Convert.ToDateTime("07/12/1983", nzCulture), YearsExperience = 1 });
            sampleData.Add(new Person { FirstName = "One", LastName = "Ohter Kind", Birthday = Convert.ToDateTime("02/02/1970", nzCulture), YearsExperience = 5 });
            sampleData.Add(new Person { FirstName = "Some", LastName = "Lovely human", Birthday = Convert.ToDateTime("09/07/1980", nzCulture), YearsExperience = 7 });
            
            return sampleData;
        }
    }
}
