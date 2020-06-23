using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {   //Note: Define multiple variables in one line;
            //double length, width;

            //Add a print line to prompt the user for the length of the rectangle.
            Console.WriteLine("What is the length of the rectangle?");

            //Define a variable to handle the user’s response.
            
            double length = double.Parse(Console.ReadLine());

            //Repeat the previous two steps to ask for and store the rectangle’s width.
            Console.WriteLine("What is the width of the rectangle?");

            //Use the length and width values to calculate the rectangle’s area.
            double width = double.Parse(Console.ReadLine());

            //Print a statement using concatenation to communicate to the user what the area of their rectangle is.
            Console.WriteLine("The area of the rectangele is " + width * length);
        }
    }
}
