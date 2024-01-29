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
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            string firstName = Console.ReadLine();
            string middleName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            //math section
            string integerInput = Console.ReadLine();
            int integer1 = Convert.ToInt32(integerInput);

            string integerInput2 = Console.ReadLine();
            int integer2 = Convert.ToInt32(integerInput2);

            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");

            Console.WriteLine($"{integer1} - {integer2} = {integer1 + integer2}");

            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");

            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");

            Console.WriteLine($"{integer1} % {integer2} = {integer1 / integer2}");








        }
    }
}
