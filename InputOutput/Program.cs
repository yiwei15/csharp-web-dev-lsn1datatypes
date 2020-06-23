using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare all variables at the top
            // Put our prompt in to a variable and use the variable in the WriteLine
            // Let's declare our name variable at the top, but assgin it with ReadLine
            // Let's creat a variable to hold our greering;

            //string prompt = "What is your name?";
            //string name;
            //string greeting = "Hiya";
            //System.Console.WriteLine(prompt);
            //name = System.Console.ReadLine();
            //System.Console.WriteLine(greeting + " " + name);

            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
        }
    }
}
