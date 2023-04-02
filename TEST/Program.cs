using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Questions
    {
        static void Main(string[] args)
        {
            //Declare our variables 
            string fullName = string.Empty;
            int age;
            double salary;
            char gender;
            Boolean working;

            //Questions to the user 
            Console.WriteLine("Tell me your name? ");
            fullName = Console.ReadLine();

            //Question to the user on age which mentioned their name and we converted from string to Int
            Console.WriteLine($"How old are you {fullName}?");
            age = Convert.ToInt32(Console.ReadLine());

            //Question about salary
            Console.WriteLine("How much do you earn?");
            salary = Convert.ToDouble(Console.ReadLine());

            //Question gender 
            Console.WriteLine("Are you Male or Female? use M or F");
            gender = Convert.ToChar(Console.ReadLine());

            //Working or not Question
            Console.WriteLine($"Are you currently in employment {fullName} ? Use true/false");
            working = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"Your name is {fullName}");
            Console.WriteLine($"You are {age} years old");
            Console.WriteLine($"You earn £{salary}");
            Console.WriteLine($"You are {gender}");
            Console.WriteLine($"You are working {working}");
            Console.ReadKey();
        }
    }
}
