using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string fullName = string.Empty; ;
            int age;
            double salary;
            char gender = char.MinValue;
            bool working;


            //prompt the user to input each of these 
            Console.Write("Please enter you full name ");
            fullName = Console.ReadLine();
            
            //Asked the user to enter their age and stored it in a variable
            Console.Write("What is your age? ");
            age = Convert.ToInt32(Console.ReadLine());

            //Asked the user to enter their salary and stored it in a variable
            Console.Write("What is your salary? ");
            salary = Convert.ToDouble(Console.ReadLine());

            //asked the user to enter their gender and stored it in a variable
            Console.Write("What is your gender? (M or F): ");
            gender = Convert.ToChar(Console.ReadLine());

            //asked the user to enter if they are working and stored it in a variable
            Console.Write("Are you working? (True or False): ");
            working = Convert.ToBoolean(Console.ReadLine());

            //output the variables to the console
            Console.WriteLine("Your name is: " + fullName);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine($"Your salary: is {salary}");
            Console.WriteLine($"You are a: {gender}");
            Console.WriteLine($"You are employed: {working}");

            Console.ReadKey();

            
        }
    }
}
