using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {

            //We assigned a value to a variable from right to left. 
            //We used the variable to write out different messages and created one sum container for two variables calculated together. 
            //Half way through the code we modified our variable to be different. 
            //We then used our altered variable again in more written out messages to get different results. 

            //Basic assignment - assigns the value from right to the variable on left. 
            int num = 5;

            //Arithmetic operators 
            int num1 = 11;
            int num2 = 12;

            //Notice that the variables in the string that are added together sit together as a sum {we sit in here together}
            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");
            Console.WriteLine($"Division: {num1 / num2}");
            Console.WriteLine($"Modulus: {num1 % num2}");

            //We can change the value in the num1 variable easily so going forward line by line the variable value eventually changed. 
            num1 = num1 + 4; //This increased the variables value by 4. It is now 15.
            Console.WriteLine(num1);

            num1 = num1 - 4; //This would decrease the variable number by 4. it is now 11.
            Console.WriteLine(num1);

            num1 = num1 * 4; //This would multiple the variable number by 4. it is now 44.
            Console.WriteLine(num1);


            //Write it using shorthand for simplicity using compound assignment operators. 
            num1 = num1 + 4; //it is now 44 - 4 = 40
            Console.WriteLine(num1);

            //There is  a shorter way of doing this. 
            num1 += 4; //it is now 40 + 4 = 44
            Console.WriteLine(num1);

            num1 -= 4; // it is now 40
            Console.WriteLine(num1);

            num1 *= 4; // it is now 160
            Console.WriteLine(num1);


            //We changed the top line text to say we have a new value in num1 now. Num1 was 11 but then it was 11-4 = 7, then below it is 7 - 12. 
            Console.WriteLine($"New value of num1: {num1}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");
            Console.WriteLine($"Division: {num1 / num2}");
            Console.WriteLine($"Modulus: {num1 % num2}");
            

           

            Console.ReadLine();

        }
    }
}
