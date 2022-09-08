using System;
using System.Collections.Generic;

namespace EventDelegateDemo
{
    public class Student
    {
        private readonly List<string> _students = new List<string>();

        public Action<string> NewStudentAdded;

        public void AddNewStudent(string studentName)
        {
            _students.Add(studentName);
            NewStudentAdded?.Invoke(studentName);
        }
    }

    public class StudentWelcome
    {
        public void WelcomeStudent(string studentName)
        {
            Console.WriteLine($"To Student: Welcome {studentName}");
        }
    }

    public class SetupAccount
    {
        public void InformITteam(string studentName)
        {
            Console.WriteLine($"To IT team: {studentName} has just enroll to the Web developement course...");
        }
    }
}