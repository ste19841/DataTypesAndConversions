using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //We assigned a value to a variable from right to left.
            int value1 = 5;
            int value2 = 14;
            int num1 = 5;
            int num2 = 23;
            //We assigned a value to a variable from right to left but this time we used a calculated value
            int sumofnum1num2 = num1 + num2;

            //We used the variable to write out different messages and created one sum container for two variables calculated together.
            int sumAddition = value1 + value2;
            int sumMinus = value1 - value2;
            int sumMultiply = value1 * value2;

            //We wrote out the total of the sumaddtion value. 
            Console.WriteLine($"Here is the sum value  {sumAddition}. This is from the addition of {value1} and {value2}.  ");

            //We wrote out the total of the sumMinus value.
            Console.WriteLine($"Addition: {num1} + {num2} = {sumofnum1num2}"); 

            //We asked for the user input on a number of apples and stored it in a variable
            Console.WriteLine("Enter number of apples");
            int numberofApples = Convert.ToInt32(Console.ReadLine());

            //We asked for the user input on a number of oranges and stored it in a variable
            Console.WriteLine("Enter number of oranges ");
            int numberofOranges = Convert.ToInt32(Console.ReadLine());

            //if the number of apples was greater than the number of oranges we would write out a message saying so.
            if (numberofApples > numberofOranges)
            {
                Console.WriteLine($"You have more apples! There are {numberofApples} apples and {numberofOranges} oranges. ");

            }
            //if the number of apples was less than the number of oranges we would write out a message saying so.
                else if (numberofApples < numberofOranges)

                Console.WriteLine($"You have more oranges. There are {numberofApples} apples and {numberofOranges} oranges. ");     

            //if the number of apples was equal to the number of oranges we would write out a message saying so.
           else if (numberofApples == numberofOranges)

            {
                Console.WriteLine("You have an equal number of apples and oranges");

            }

            //switch statements 
            //enter final grade and int grade

            //Asked the user to enter a final grade and then used interpolation and stored it in a variable. 
            Console.WriteLine("Enter final grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            //used a switch statement to write out a message based on the grade entered.
            switch (grade)
            {
                case int lowGrade when (lowGrade <=60): 
                        Console.WriteLine("You Failed");
                    break;
                    
                case int highGrade when highGrade >= 60 && highGrade < 100:
                    Console.WriteLine("You passed");
                    break;

                case int invalidGrade when invalidGrade >= 100:
                    Console.WriteLine("Invalid grade");
                    break;


            }
            
            Console.ReadLine();


        }
    }
}
