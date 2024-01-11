﻿// See https://aka.ms/new-console-template for more information

using System;

public class DiceRoller
{
    public static int[] RollDice(int numberOfRolls)
    {
        int[] results = new int[13]; // Indices 0 and 1 will not be used
        Random random = new Random();

        for (int i = 0; i < numberOfRolls; i++)
        {
            int roll = random.Next(1, 7) + random.Next(1, 7); // Rolling two 6-sided dice
            results[roll]++;
        }

        return results;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

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