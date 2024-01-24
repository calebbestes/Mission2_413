//Create 2 6-sided dice
//Create array to keep track of number of times each combo is thrown
//Allow user to choose how many times the dice will be thrown (writeline)
//return array and print a histogram using *


using MoreCSharp;
internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls = 0;

        //Instantiaion and declaration of class Roll Dice
        RollDice dice = new RollDice();


        System.Console.WriteLine("Welcome to the dice throwing simulator! " +
            "\n How many dice rolls would you like to simulate?: ");
        //sets user input to numrolls
        numRolls = int.Parse(System.Console.ReadLine());




        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls = " + numRolls);
        //Goes to RollDice class
        dice.Simulate(numRolls);
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}