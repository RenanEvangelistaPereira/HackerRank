using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
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

        /// <summary>
        /// Given the meal price (base cost of a meal), tip percent (the percentage of the meal price being added as tip), and tax percent (the percentage of the meal price being added as tax) for a meal, find and print the meal's total cost.
        /// Note: Be sure to use precise values for your calculations, or you may end up with an incorrectly rounded result!
        /// </summary>
        /// <param name="meal_cost">The first line has a double, mealCost (the cost of the meal before tax and tip).</param>
        /// <param name="tip_percent">The second line has an integer, tipPercent (the percentage of mealCost being added as tip).</param>
        /// <param name="tax_percent">The third line has an integer, taxPercent (the percentage of mealCost being added as tax).</param>
        public static int DayTwo(double meal_cost, int tip_percent, int tax_percent)
        {
            double totalCost = meal_cost + (meal_cost * tip_percent / 100) + (meal_cost * tax_percent / 100);
            return Convert.ToInt32(totalCost);
        }

        /// <summary>
        /// In this challenge, we're getting started with conditional statements
        /// Given an integer, n, perform the following conditional actions:
        /// - If n is odd, print Weird
        /// - If n is even and in the inclusive range of 2 to 5, print Not Weird
        /// - If n is even and in the inclusive range of 6 to 20, print Weird
        /// - If n is even and greater than 20, print Not Weird
        /// </summary>
        /// <param name="n">a positive integer, n. 1 less than or equals to "n" less than or equals to 100</param>
        /// <returns></returns>
        public static string DayThree(int n)
        {
            ListDictionary validKindOfResults = new ListDictionary
            {
                { "1", "Weird" },
                { "2", "Not Weird" },
                { "3", "Alien Result" }
            };

            if (n % 2 == 1 && n >= 1)
            {
                return validKindOfResults["1"].ToString();
            }
            else if (n >= 2 && n <= 5)
            {
                return validKindOfResults["2"].ToString();
            }
            else if (n >= 6 && n <= 20)
            {
                return validKindOfResults["1"].ToString();
            }
            else if( n > 20 && n <= 100)
            {
                return validKindOfResults["2"].ToString();
            }

            return validKindOfResults["3"].ToString(); 
        }

    }


}
