using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateOfBirth = new DateTime(1984, 09, 09);
            Console.WriteLine($"My DOB is {dateOfBirth}");

            DateTime now = DateTime.Now;
            Console.WriteLine("The time right now is:" + now);


            //parsing a date from a string
            string crapDate = "09 September 1984";
            DateTime parsedDate = DateTime.Parse(crapDate);
            Console.WriteLine("Here is the much neater parsed date: " + parsedDate);

            //Add one hour to the current time and print it. 
            Console.WriteLine("In 1 hour it will be " + now.AddHours(1));

            //Add days
            Console.WriteLine("what date will it be in " + now.AddDays(8000));

            Console.ReadKey();

        }
    }
}
