using System;

namespace EventDelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            var welcomer = new StudentWelcome();
            var accountSetup = new SetupAccount();

            student.NewStudentAdded += welcomer.WelcomeStudent;
            student.NewStudentAdded += accountSetup.InformITteam;

            student.AddNewStudent("Benny");

        }
    }
}
