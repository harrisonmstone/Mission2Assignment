using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    internal class Class1
    {
        public void RollDice(int TotalRolls)
        {
            // Create an instance of the Random class
            Random random = new Random();
            // Declare the integer list that will hold the asterisks later
            int[] tracker = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            // Go through this for loop for the TotalRolls chosen by the user
            // Use the random instance to simulate a random number
            // Keeps track of how many was rolled using our tracker list
            for (int ct = 0; ct < TotalRolls; ct++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;
                tracker[sum - 2] = tracker[sum - 2] + 1;
            }
            // Output as described in instructions
            // For loop iterates through each value in the tracker list, calculates its percent,
            // and adds an asterisk accordingly
            System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS \nEach \"*\" represents 1% of the total number of rolls. \nTotal number of rolls = " + TotalRolls + ".\n");
            for (int ct = 0; ct < tracker.Length; ct++)
            {
                string asterisks = "";
                float percentage = ((float)tracker[ct] / TotalRolls) * 100;
                for (int ct2 = 0; ct2 < percentage; ct2++)
                {
                    asterisks = asterisks + "*";
                }
                System.Console.WriteLine($"{ct + 2}: {asterisks}");
            }
            System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
