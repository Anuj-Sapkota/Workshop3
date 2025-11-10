using System;

namespace Task03
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter your age: ");
            string? input = Console.ReadLine();

            // Convert input to integer safely
            if (int.TryParse(input, out int age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Age cannot be negative.");
                }
                else if (age < 13)
                {
                    Console.WriteLine("child.");
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine("Teenager.");
                }
                else if (age >=20)
                {
                    Console.WriteLine("Adult.");
                }
                else
                {
                    Console.WriteLine("You are a senior citizen.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}