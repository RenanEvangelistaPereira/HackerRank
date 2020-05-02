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
        public static void DayZero(String param = "Welcome to 30 Days of Code!")
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

        /// <summary>
        /// Day 1: Data Types
        /// </summary>
        /// <param name="args"></param>
        public static void DayOne(int paramOne, double paramTwo, string paramThree)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int iT = 0; //paramOne;
            double dT = 0d; //paramTwo;
            string sT = string.Empty; //paramThree;

            // Read and save an integer, double, and String to your variables.
            iT = Convert.ToInt32(Console.ReadLine());
            dT = Convert.ToDouble(Console.ReadLine());
            sT = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i+iT);
            // Print the sum of the double variables on a new line.
            Console.WriteLine($"{(d + dT):F1}");
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine($"{s}{sT}");
        }

    }


}
