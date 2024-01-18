using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    public class DiceRoller
    {
        public static int[] RollDice(int numberOfRolls)
        {
            // Create an array to hold the results of dice rolls
            // The array has 13 elements, but indices 0 and 1 will not be used
            int[] results = new int[13]; 
            Random random = new Random();

            // Loop for the number of times specified by numberOfRolls.
            for (int i = 0; i < numberOfRolls; i++)
            {
                // Simulate rolling two 6-sided dice and summing their values
                int roll = random.Next(1, 7) + random.Next(1, 7); 
                results[roll]++;
            }

            // Return the array of results
            return results;
        }
    }
}



