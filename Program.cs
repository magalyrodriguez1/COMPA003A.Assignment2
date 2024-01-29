/*
 * Author: Magaly Rodriguez
 * Course: COMP-003A
 * Purpose: Learning programming basics like strings and doing calculations
 * */


namespace COMPA003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Console Section");
            Console.WriteLine("*******************************************");

            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue; //changes background color to blue
            Console.ForegroundColor = ConsoleColor.White; //changes text color to white

            Console.WriteLine("*******************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Middle Name: ");
            string middleName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter age in 2023: ");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge); //Convert.ToInt32 converts string to integer

            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            //math section
            Console.WriteLine("*******************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Enter an integer for integer1: ");
            string integerInput = Console.ReadLine();
            int integer1 = Convert.ToInt32(integerInput);

            Console.WriteLine("Enter an integer for integer2: ");
            string integerInput2 = Console.ReadLine();
            int integer2 = Convert.ToInt32(integerInput2);

            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");

            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");

            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");

            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");

            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

            //circle area and circumference calculator section
            Console.WriteLine("*******************************************");
            Console.WriteLine("Circle Area and Circumference Section");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine("The area is " + area);
            Console.WriteLine($"The circumference is {circumference}");










        }
    }
}
