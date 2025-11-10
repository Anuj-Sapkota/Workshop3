using System;
    public class Program
    {
        public static void Main()
        {
            // Console.Write("Enter a number: ");
            // string input = Console.ReadLine();
            //
            // try
            // {
            //     int number = int.Parse(input!); 
            //     Console.WriteLine("You entered: " + number);
            // }
            // catch (Exception)
            // {
            //     Console.WriteLine("Invalid number format");
            // }
            // finally
            // {
            //     Console.WriteLine("Program Executed");
            // }
            
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            try
            {
                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
