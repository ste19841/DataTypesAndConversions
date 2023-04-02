using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Our code outside of the method asking for user input 
            int number1, number2, number3;

            Console.WriteLine("Enter number 1: ");

            number1 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter number 2: ");

            number2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter number 3: ");

            number3 = Convert.ToInt32(Console.ReadLine());




            //Calling the method whilst using our users input values and then adding the value to a new variable called RESULT that can be used.  
            int result = LargestNumber(number1, number2, number3);

            Console.WriteLine($"The largest number is: {result}");
            Console.ReadKey();
        }




        //Start of method 

        static int LargestNumber(int num1, int num2, int num3)
        {
            int largest = num1;

            if(largest < num2)



{
                largest = num2;

            }

            if (largest < num3)
        {
                largest = num3;
            }

            return largest;
            
        }

    }
    
}

    //End of method 



   