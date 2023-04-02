using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    internal class Program
    {
        // Declare class-level variables
        static string firstName, lastName, middleName;
        static int age, height, weight;
        static bool isAlive, isHungry, isTired;

        static void Main(string[] args)
        {
            // Your existing code for collecting user input

            // Collect input for isAlive, isHungry, and isTired
            Console.WriteLine("Are you alive? (yes/no): ");
            isAlive = Console.ReadLine().ToLower() == "yes";
            Console.WriteLine("Are you hungry? (yes/no): ");
            isHungry = Console.ReadLine().ToLower() == "yes";
            Console.WriteLine("Are you tired? (yes/no): ");
            isTired = Console.ReadLine().ToLower() == "yes";

            // New code: Ask the user for input and call the 'User' method
            Console.WriteLine("How can I help you?");
            string userInput = Console.ReadLine();

            if (userInput.ToLower().Contains("user"))
            {
                User();
            }
        }

        static void User()
        {
            Console.WriteLine($"User Details:");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Middle Name: {middleName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height} cm");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Is Alive: {isAlive}");
            Console.WriteLine($"Is Hungry: {isHungry}");
            Console.WriteLine($"Is Tired: {isTired}");
        }
    }
}
