using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //for 
            //open brackets and declare data type of variable and use i for variable 
            //starting value is 0 and end statement; next statement is the maximum value; then say variable with ++ to increment by 1 each time or +=2 to jump up by 2 each time
            //using i is irrelevant the variable can be any name 
            
          for(int i = 0; i <10; i++)
               //You could use this just to show that the i means nothing special //for(int counter = 0; counter <10; counter++)
            {
                Console.WriteLine("I am in a loop");
                Console.WriteLine($"counter: {i}");
            }
          
          //This for has a variable called counter and has a value of 10 which can go up to no more than 20 in increments of 2. 
            for (int counter = 10; counter < 20; counter+=2)
            {
                Console.WriteLine("I am in a loop too");
                Console.WriteLine($"Counter: {counter}");
            }

            for (int counter = 6; counter < 500; counter += 5)
            {
                Console.WriteLine("Final Countdown");
                Console.WriteLine($"Counter: {counter}");
            }

            //add something outside of the loops code {} block. 
            Console.WriteLine("For loop finished.");
            
            //While loop 

            for(int i = 0; i < 100; i+=5)
            {
                Console.WriteLine($"Looping {i}");
            }

            //while loop 
            int oldValue = 50;
            int newValue = 1;

            while (newValue < oldValue)
            {
               Console.WriteLine("Try to enter the number which will end this loop. If the first number does not work, try a higher number.");
                newValue = Convert.ToInt32(Console.ReadLine());
            }
            if (newValue >= 50)
            {
                Console.WriteLine($"Well Done! You entered {newValue}! Game Over. ");
            }

            do
            {

            } while (true);

            Console.ReadLine();
        }
    }
}

