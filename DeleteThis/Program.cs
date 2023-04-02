using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write me some code where we have some unique variables
            //and we use the if else statement to determine which one is greater than the other
            //and the user gets to input the values
            Console.WriteLine();
            Console.WriteLine("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter a third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();    
            Console.WriteLine("The numbers you entered are: " + number1 + ", " + number2 + ", " + number3);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The largest number is: ");
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine(number1);
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine(number2);
            }
            else if (number3 > number1 && number3 > number2)
            {
                Console.WriteLine(number3);
            }
            else
            {
                Console.WriteLine("The numbers are equal");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The smallest number is: ");
                Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (number1 < number2 && number1 < number3)
            {
                Console.WriteLine(number1);
            }
            else if (number2 < number1 && number2 < number3)
            {
                Console.WriteLine(number2);
            }
            else if (number3 < number1 && number3 < number2)
            {
                Console.WriteLine(number3);
            }
            else
            {
                Console.WriteLine("The numbers are equal");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
