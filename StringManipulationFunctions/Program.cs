using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //We will look at different string manipulations 
            //Counting character length - properties 
            //Replacing characters - methods

            //Decalre some variables. 
            string firstName;
            string lastName;
            int firstNameLength;
            int lastNameLength;
            int totalLength;

            //We ask the user some questions and store their input. 
            Console.WriteLine("What is your first name? ");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name? ");
            lastName = Console.ReadLine();


            //We work out the length of the names
            firstNameLength = firstName.Length; 
            lastNameLength = lastName.Length;

            //We add the lengths together to get the total length of the name and store it in a new variable.
            totalLength = firstNameLength + lastNameLength;

            //We output the results to the user.
            Console.WriteLine($"Your name is {firstName} {lastName} and the length of your name is: ");
            Console.WriteLine($"First Name: {firstNameLength} ");
            Console.WriteLine($"Last Name: {lastNameLength}");
            Console.WriteLine($"Your total name length is: {totalLength} characters long. ");

            //This uses the .Replace method to replace the letter e with the letter z.
            string ChangedName = firstName.Replace('e', 'z');
            Console.WriteLine($"My first name is now spelt {ChangedName}");

            //this uses the .ToString method to convert the number 123456 to a string.
            string converted = 123456.ToString();
            Console.WriteLine($"This is the converted string: {converted}");


            //We use this to ensure the console does not just close. 
            Console.ReadKey();
        }
    }
}
