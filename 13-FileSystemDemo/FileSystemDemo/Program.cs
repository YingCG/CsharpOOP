using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string rootPath = @"C:\Users\Ying\Desktop\CsharpOOP-WindowsForm\13FileSystemDemo";
            string[] directories = Directory.GetDirectories(rootPath);
            //string[] directories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                //Console.WriteLine(file);
                Console.WriteLine(Path.GetFileName(file));
            }

            string nameFile = @"C:\Users\Ying\Desktop\CsharpOOP-WindowsForm\13FileSystemDemo\DocumentFolder\NameAndWebpage.txt";
            string filename = "NameAndWebpage.txt";
            var websiteDocument = Path.Combine(rootPath, filename);
            string[] lines = File.ReadAllLines(nameFile);
            List<string> info = new List<string>();
            //info = File.ReadAllLines(websiteDocument).ToList();

            // write file
            info.Add("Tim, Jane, www.somebody.com");
            File.WriteAllLines(websiteDocument, info);
            foreach (String line in info)
            {
                Console.WriteLine(line);
            }

            //List<string> customerInfo = new List<string>();
            //List<Person> people = new List<Person>();
            //foreach(string cInfo in customerInfo)
            //{
            //    string[] items = cInfo.Split(',');
            //    Person p = new Person(items[0], items[1], items[2]);
            //    people.Add(p);

            //}

            Console.ReadLine();
        }
    }
}
