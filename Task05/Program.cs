using System;


    public class Program
    {
        public static void Main()
        {
           
            // Console.Write("Enter a number N: ");
            // string input = Console.ReadLine();
            //
            // if (int.TryParse(input, out int N) && N > 0)
            // {
            //     int sum = 0;
            //     for (int i = 1; i <= N; i++)
            //     {
            //         sum += i;
            //     }
            //     Console.WriteLine($"Sum from 1 to {N} is: {sum}");
            // }
            // else
            // {
            //     Console.WriteLine("Invalid input! Enter a positive integer.");
            // }
            
            int i = 1;
            while (i <= 20)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue; 
                }

                if (i == 15)
                {
                    break; 
                }

                Console.WriteLine(i);
                i++;
            }
        }
    }

