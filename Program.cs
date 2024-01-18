// Program.cs
// Jack Carpenter
// Section 1-9
// This program is a simulation of a dice roller, it rolls two six-sided die and then generates a histogram of the percentage of numbers rolled
using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main()
        {
            // Greet the user
            Console.WriteLine("Welcome to the dice throwing simulator!");
            
            // Ask user for the number of dice rolls
            Console.Write("How many dice rolls would you like to simulate? ");
            int numberOfRolls;

            // Attempt to parse the user input as an integer
            if (!int.TryParse(Console.ReadLine(), out numberOfRolls))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            // Call the RollDice method from the DiceRoller class
            int[] rollResults = DiceRoller.RollDice(numberOfRolls);
            PrintHistogram(rollResults, numberOfRolls);

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }

        // Call the PrintHistogram method that takes the results of the dice rolls and generates a histogram
        static void PrintHistogram(int[] results, int totalRolls)
        {
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {totalRolls}.");

            // Loop through the possible dice roll outcomes
            for (int i = 2; i <= 12; i++)
            {
                //Calculate the percentage of rolls that resulted in the current outcome
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
