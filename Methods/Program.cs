using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetAlien(); //this calls the method
           

         Console.ReadKey();
        }

        static void MeetAlien()
        {
            Random numberGen = new Random();
            string name = "x-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi, I am " + name + "");
            Console.WriteLine("I am " + age + " years old");
            Console.WriteLine("Oh, and I am an alien.");

            //Write a line of code which uses the IF statement to check if a result is an even number 
            if (age % 2 == 0)
            {
                Console.WriteLine("I am an even number");
            }
            else
            {
                Console.WriteLine("I am an odd number");
            }
          
        }
      


    }


}

