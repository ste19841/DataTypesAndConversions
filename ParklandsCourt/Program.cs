using System;

namespace ParklandsCourt
{
    class ParklandsCourt
    {
        static void Main(string[] args)
        {
            // Variables
            string name;
            string magicWord;
            bool correctMagicWord = false;
            int answer;
            bool correctAnswer = false;

            Console.WriteLine("Hello");

            // Question on name and answer
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            // Response to answer
            Console.WriteLine($"Hello {name}, it is nice to meet you.");

            do
            {
                Console.WriteLine("To enter this game, you need to know the magic word. What is the magic word?");
                magicWord = Console.ReadLine();

                if (magicWord == "tesla")
                {
                    Console.WriteLine("GAME UNLOCKED. You can now almost enter, good luck!");
                    correctMagicWord = true;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not the correct magic word, would you like to try again? Y/N");
                    string retry = Console.ReadLine();

                    if (retry.ToUpper() != "Y")
                    {
                        break; // Exit the loop if the user enters something other than "Y" or "y"
                    }
                }
            } while (!correctMagicWord);

            do
            {
                Console.Write("I have one more question for you");
                Console.WriteLine("What is 6 + 12?");
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 18)
                {
                    Console.WriteLine("Well done, please enter");
                    correctAnswer = true;
                }
                else
                {
                    Console.WriteLine("Wrong, Try again");
                }
            } while (!correctAnswer); // Added the loop condition

            Console.ReadLine();
        }
    }
}
