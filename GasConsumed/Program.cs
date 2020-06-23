using System;

namespace GasConsumed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add a print line to prompt the user for the number of miles they have driven
            //Define a variable to store the user's input
            Console.WriteLine("How many miles have you driven?");
            double numOfMiles = double.Parse(Console.ReadLine());

            //Add another print line to prompt the user for the amount of gas they've consumed
            //Define a variable to store the user's input
            Console.WriteLine("How many gas have you consumed?");
            double amountOfGas = double.Parse(Console.ReadLine());

            //Print a statement to tell the user their miles-per-gallon
            Console.WriteLine("Your miles-per-gallon is " + amountOfGas / numOfMiles + ".");
        }
    }
}
