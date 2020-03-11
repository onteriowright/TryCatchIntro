using System;

namespace TryCatchIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int difficulty = 0;

            while (true)
            {
                Console.Write("What is the bank difficulty? ");
                var userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Console.WriteLine("Closing App!");
                    break;
                }
                try
                {

                    difficulty = int.Parse(userInput);

                    var total = 100 / difficulty;
                    Console.WriteLine(total);

                }
                catch (System.Exception ex)
                {
                    Console.WriteLine($"Oops something went wrong! {ex.Message}");
                }
            }

        }
    }
}