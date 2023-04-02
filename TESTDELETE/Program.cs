using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTDELETE
{
    internal class Program
    {
        //write your method called print and ensure its perameters include first name and last name. 
        static void print(string firstName, string lastName)

        {
            //write your code here - //Your method should have a writeline statement telling the user their name is firstname lastname 
            Console.WriteLine($"Your name is {firstName} + {lastName} !");
        }

        static void Main(string[] args)
        {
            
            //we ask the user two seperate questions, their first name and last name and store answers in two seperate variables
            Console.WriteLine("What is your first name? "); 
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name? ");
            string lastName = Console.ReadLine();

            //we then call our method to print out the details with one simple call. 
            //what is wrong with the method call below?

            print(firstName, lastName); //we are calling the method print and passing in the two variables we created above.
            
            

        }
    }

}
    

