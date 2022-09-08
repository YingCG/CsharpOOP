using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemDemo
{
    class Person
    {
        public Person(string firstName, string lastName, string URL)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.URL = URL;
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string URL { get; set; }
    }
}
