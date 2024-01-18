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
}



