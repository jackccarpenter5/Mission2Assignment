// Program.cs
using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int numberOfRolls;
            if (!int.TryParse(Console.ReadLine(), out numberOfRolls))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            int[] rollResults = DiceRoller.RollDice(numberOfRolls);
            PrintHistogram(rollResults, numberOfRolls);

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }

        static void PrintHistogram(int[] results, int totalRolls)
        {
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {totalRolls}.");

            for (int i = 2; i <= 12; i++)
            {
                int percentage = (results[i] * 100) / totalRolls;
                Console.Write($"{i}: ");
                for (int j = 0; j < percentage; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
