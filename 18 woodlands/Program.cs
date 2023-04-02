using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_woodlands
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables with a default value
            string name;
            int age;
            bool happy;

            //asking a question and storing the answer in a variable
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();

            //Asking a question and storing the answer in a variable
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            //Using the variables in a message

            //if the age is less than 30, write a message
            if (age < 30)
            {
                Console.WriteLine("Wow, aren't you young!");
            }
            //if the age is greater than or equal to 30, write a message
            else if (age >=30)
            {
                Console.WriteLine("Wow, aren't you old!");
            }

            //If the age is less than 30, ask a question and store the answer in a variable
            if (age<30)
            {
                Console.WriteLine("I bet you are happy. Are you happy?");
                happy = Convert.ToBoolean(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
