using Mission2Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        // Declare the variable of TotalRolls to give it a value later
        int TotalRolls = 0;
        // Write lines to introduce the user and receive rolls input
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.Write("How many dice rolls would you like to simulate? ");
        // Set the TotalRolls to what the user entered
        TotalRolls = int.Parse(System.Console.ReadLine());
        // Create an instance of the dice class and call the RollDice method to simulate the rolling
        Class1 dice = new Class1();
        dice.RollDice(TotalRolls);

    }
}