using System;

namespace Task02
{
    public class NullOperations
    {
        public void PerformNullChecks()
        {
            string? username = null; // nullable string

            // Ternary operator
            string result = username == null ? "Username is not available" : username;
            Console.WriteLine(result);

            // Null-coalescing operator
            Console.WriteLine(username ?? "Username is not available");

            // Null-coalescing assignment operator
            username ??= "Anuj";
            Console.WriteLine(username);
        }
    }
}