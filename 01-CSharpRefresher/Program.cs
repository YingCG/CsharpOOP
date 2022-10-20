using System;
using System.Collections.Generic;

namespace CSharpSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! These activities are formulated to refresh the previously learned C# concepts.");

            Console.WriteLine("Press 1 to Fahrenheit Converter" +
                "\nPress 2 to Number Checker " +
                "\nPress 3 To Get Average Number " +
                "\nPress 4 To Multiply Table " +
                "\nPress 5 To Calculator " +
                "\nPress 6 to Speed Converter" +
                "\nPress 7 to Get Volume Of Sphere");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Please enter a celcius degree you wish to convert");
                string input = Console.ReadLine();
                float celcius = float.Parse(input);
                Console.WriteLine(ConvertToFahrenheit(celcius));
            }
            if (choice == "2")
            {
                Console.WriteLine("Please enter your First Number");
                string firstNum = Console.ReadLine();
                int num1 = Convert.ToInt32(firstNum);
                Console.WriteLine("Please enter your Second Number");
                string secondNum = Console.ReadLine();
                int num2 = Convert.ToInt32(secondNum);

                Console.WriteLine(NumberChecker(num1, num2));
                Console.ReadLine();
            }
            if (choice == "3")
            {
                Console.WriteLine("Please enter your 10 numbers");
                int[] numbers = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    string input = Console.ReadLine();
                    int inputAsInt = int.Parse(input);
                    numbers[i] = inputAsInt;
                }

                Console.WriteLine(GetAverage(numbers));
            }
            if (choice == "4")
            {
                Console.WriteLine("Show Multiple Table of number: ");
                string input = Console.ReadLine();
                int inputNum = Convert.ToInt32(input);

                MultiplicationTable(inputNum);
            }
            if (choice == "5")
            {
                Console.WriteLine("Enter 2 number: ");
                string input = Console.ReadLine();
                string[] number = input.Split(",");
                float a = Convert.ToSingle(number[0]);
                float b = Convert.ToSingle(number[1]);
                Calculator(a, b);
            }
            if (choice == "6")
            {
                Console.WriteLine("Enter distance in meter: ");
                string distance = Console.ReadLine();
                double meter = Convert.ToDouble(distance);

                Console.WriteLine("Input time (hour): ");
                string inputHour = Console.ReadLine();
                int hourToMins = Convert.ToInt32(inputHour) * 60;

                Console.WriteLine("Input time (minutes): ");
                string inputMins = Console.ReadLine();
                int minutes = Convert.ToInt32(inputMins);

                Console.WriteLine("Input time (seconds): ");
                string inputSecond = Console.ReadLine();
                int secondToMinutes = Convert.ToInt32(inputSecond) / 60;

                int totalminutes = hourToMins + minutes + secondToMinutes;
                SpeedChecker(meter, totalminutes);
            }
            if (choice == "7")
            {
                Console.WriteLine("Enter radius of a sphere to calculate the volume: ");
                string inputRadius = Console.ReadLine();
                double radius = Convert.ToDouble(inputRadius);
                VolumeOfSphere(radius);
            }
        }

        static float ConvertToFahrenheit(float celcius)
        {
            //converts celcius to Fahrenheit degrees
            float result = (celcius * 9f / 5f) + 32f;
            return result;
        }

        static float ConvertToCelcius(float fahrenheit)
        {
            //converts Fahrenheit to celcius degrees
            float result = (fahrenheit + 32f) * 5f / 9f;
            return result;
        }

        //Two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns their sum.
        static int NumberChecker(int num1, int num2)
        {
            if ((num1 % 2 == 0 || num1 % 3 == 0) && (num2 % 2 == 0 || num2 % 3 == 0))
            {
                return num1 * num2;
            }
            else
            {
                return num1 + num2;
            }
        }

        // Task 3: 
        // A method to take 10 numbers as input from user and find their sum and average. 
        static float GetAverage(IList<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = (number + sum);
            }
            float average = sum / Convert.ToSingle(numbers.Count);
            return average;
        }

        // Task 4:
        // Display the multiplication table of a given integer
        static void MultiplicationTable(int number)
        {
            Console.WriteLine("Multiply of " + number);
            for (var i = 1; i <= 10; i++)
            {
                int line = i * number;
                Console.WriteLine(i + " x " + line);
            }
        }

        // Task 5: 
        // print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.  
        static void Calculator(float num1, float num2)
        {
            float add = num1 + num2;
            float subtract = num1 - num2;
            float multiply = num1 * num2;
            float divide = num1 / num2;

            //Console.WriteLine("Add: " + add);
            //Console.WriteLine("Subtract: " + subtract);
            //Console.WriteLine("Multiply: " + multiply);
            //Console.WriteLine("Divide: " + divide);

            Console.WriteLine("Add: {0}\nSubtract: {1}\nMultiply: {2}\nDivide: {3}",
                add,
                subtract,
                multiply,
                divide);
        }

        // Task 6:
        // Takes distance and time as input and displays the speed in kilometers per hour and miles per hour. 
        static void SpeedChecker(double meter, int mins)
        {
            double meterPerMinutes = meter / mins;
            double meterPerSecond = meterPerMinutes / 60;
            double kmPerMinutes = meterPerMinutes / 1000;
            double kmPerHour = kmPerMinutes * 60;
            double milesPerHour = kmPerHour / 1.609f;

            Console.WriteLine("Your speed in meters / sec is: " + meterPerSecond);
            Console.WriteLine("Your speed in km / h is: " + kmPerHour);
            Console.WriteLine("Your speed in miles / h is: " + milesPerHour);
        }

        // Task 7:
        // the radius of a sphere as input and calculate and display the surface area and volume of the sphere.   
        /* Expected input and output

        Radius: 2 
        Expected Output: 
        Surface Area of the Sphere: 50.26548 
        Volume of the Sphere: 33.51032  */
        static void VolumeOfSphere(double radius)
        {
            double volume = 4f / 3f * Math.PI * Math.Pow(radius, 3);
            double area = 4f * Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Surface Area of the Sphere: " + area);
            Console.WriteLine("Volume of the Sphere: " + volume);

        }
    }
}


