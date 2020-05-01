using System;
using System.Collections.Generic;
using System.Text;

namespace br.com.techms.HackerRank
{
    public class Challenge30DaysOfCode
    {
        /// <summary>
        /// Day 0: Hello, World
        /// </summary>
        /// <param name="args">A single line of text denoting inputString (the variable whose contents must be printed).</param>
        static void DayZero(String param = "Welcome to 30 Days of Code!")
        {
            // Declare a variable named 'inputString' to hold our input.
            String inputString;

            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            inputString = param;//Console.ReadLine();

            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine("Hello, World.");

            // TODO: Write a line of code here that prints the contents of input_string to stdout.
            Console.WriteLine(inputString);
        }
    }
}
