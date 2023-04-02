using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsandWhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a list of cars 
            List<string> cars = new List<string>();

            //create a string variable called car 
            string car = string.Empty; 

            //create a while loop that checks some conditions which will always be false -1 until a user enters this 
            while (car != "-1") 
            {
                //the while loop should ask the user to enter a car
                Console.WriteLine("Enter car type: ");
                car = Console.ReadLine();

                cars.Add(car);

                //the while loop should tell the user the car has been added to the list 
                Console.WriteLine($"Your {car.ToUpper()} has been added to the list!");

                //Handle it if no value is entered. 
                if (car == " ")
                {
                    Console.WriteLine("Nothing added, try again");
                }

                /*
                for (int i = 0; i < cars.Count; i++)
                {
                    Console.WriteLine(cars[i].ToUpper());
                }
                */

                foreach (string item in cars) 
                {
                    Console.WriteLine(item.ToUpper());
                }
            }
            
        }
    }
}
