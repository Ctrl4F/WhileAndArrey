using System;

namespace GuessMyColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int computerNumber = rnd.Next(1, 4);
            bool rightGuess = false;

            while (!rightGuess)
            {
                Console.WriteLine("what is my color?");
                string userInput = Console.ReadLine().ToLower();
                if (computerNumber == 1 && userInput == "red")
                {
                    Console.WriteLine(" you won!");
                    rightGuess = true;

                }else if(computerNumber == 2 && userInput == "green")
                {
                    Console.WriteLine("you won");
                    rightGuess = true;
                } else if(computerNumber == 3 && userInput == "blue")
                {
                    Console.WriteLine("you won");
                    rightGuess = true;

                }
                else
                {
                    Console.WriteLine("try again");

                }

            }
        }
    }
}
