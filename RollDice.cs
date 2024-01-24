using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Get number of rolls and use a for loop to roll the dice that mny times
//return the array containing the results

namespace MoreCSharp
{
    internal class RollDice
    {
        
        public Random random = new Random();

        public void Simulate(int rolls)
        {
            //Creates two arrays representing dice to be rolled according to user input
            int[] dice1 = new int [rolls];
            int[] dice2 = new int [rolls];

            for (int i = 0; i < rolls; i++)
            {
                dice1[i] = random.Next(1, 7);
                dice2[i] = random.Next(1, 7);
            }


            Histogram(dice1, dice2);

        }
        public void Histogram(int[] dice1, int[] dice2)
        {
            int[] totalCount = new int[11];
            int [] percentageCount = new int[11];

            // For every dice roll
            for (int i = 0; i < dice1.Length; i++)
            {
                // Calculate the sum of the dice and increment the corresponding total count
                int sum = dice1[i] + dice2[i];
                totalCount[sum - 2]++;
            }

            //Convert count to percentage
            for (int i = 0; i < totalCount.Length; i++)
            {
                percentageCount[i] = (totalCount[i] * 100) / dice1.Length;
            }


            // Print the histogram using *'s
            for (int i = 2; i <= 12; i++)
            {
                //outputs each number combo
                System.Console.Write($"{i}: ");

                //turns each index of percentagecount into variable
                int count = percentageCount[i-2];

                //Prints percentage chance of each combo
                for (int j = 0; j < count; j++)
                {
                    System.Console.Write("*");
                }
                //prints it in a line. acts as a newline
                System.Console.WriteLine();
            }
        }
    }
}
