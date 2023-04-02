using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asks user questions and converts their string answer to an int
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            //asks user questions and converts their string answer to an int
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());


            try
            {
                //divides the two numbers and prints the result
                int quotient = firstNumber / secondNumber;
            }
            catch (Exception)
            {

                throw;
            }

           

            //prints out the result but in converts it back into a string format
            Console.WriteLine("The result is: " + quotient.ToString());

            //allows us to see the result
            Console.ReadKey();
        }
    }
}
