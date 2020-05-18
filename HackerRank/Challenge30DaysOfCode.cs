using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t">1 <= T <= 4  --> The first line contains an integer that denotes the number of test cases</param>
        /// <param name="ages">-5 <= age <= 30  --> An array that each member have an integer denoting the Age of a Person instance</param>
        /// <returns></returns>
        public static string DayFour(int t, int[] ages)
        {
            int T = t;
            for (int i = 0; i < T; i++)
            {
                int age = ages[i];
                PersonDayFour p = new PersonDayFour(age);
                
                p.AmIOld();
                
                for (int j = 0; j < 3; j++)
                {
                    p.YearPasses();
                }
                p.AmIOld();
                PersonDayFour.Log = " \n";
            }
            return PersonDayFour.Log;
        }


        /// <summary>
        /// Given an integer, n, print its first 10  multiples. Each multiple n x i (where 1 <= i <= 10) should be printed on a new line in the form: n x i = result.
        /// </summary>
        /// <param name="n">2 <= n <= 20</param>
        /// <returns></returns>
        public static List<OperacaoDayFive> DayFive(int n)
        {
            if (n < 2 || n > 20)
            {
                throw new ArgumentException("Please verify N. 2 <= n <= 20");
            }

            List<OperacaoDayFive> result = new List<OperacaoDayFive>();

            for (int x = 1; x <= 10; x++)
            {

                result.Add(new OperacaoDayFive() { operA = x, operation = 'x', operB = n, operResult = x * n });
            }
            return result;
        }

        public static List<string> DaySix(int t , string[] array )
        {
            if (t <= 0) {
                t = 2;
                array = new string[] { "Racker", "Rank"};
            }

            List<string> result = new List<string>();

            for (int nL = 0; nL < t; nL++)
            {
                char[] charArr = array[nL].ToCharArray();

                int lenTempS = charArr.Length;

                string leftWord = string.Empty;
                string rightWord = string.Empty;

                for (int i = 0; i < lenTempS; i++)

                    if (i % 2 == 0)
                    {
                        leftWord = leftWord + charArr[i].ToString();
                    }
                    else
                    {
                        rightWord = rightWord + charArr[i].ToString();
                    }

                result.Add($"{leftWord} {rightWord}");

            }

            return new List<string>();

        }

        public static int[] DaySeven(int[] array)
        {
            int[] reverseArray = array.Reverse().ToArray();

            return reverseArray;
        }

        public static List<string> DayEight(int n, List<string> EntriesList, List<string> QueriesForPhoneBook)
        {

            List<string> result = new List<string>();
            Dictionary<string, double> phoneBook = new Dictionary<string, double>();
            List<string> queries = new List<string>();

            for (int x = 0; x < EntriesList.Count; x++)
            {
                string[] tempArr = EntriesList[x].Split(' ');
                phoneBook.Add(tempArr[0], Convert.ToDouble(tempArr[1]));
            }
            for (int x = 0; x < QueriesForPhoneBook.Count; x++)
            {
                queries.Add(QueriesForPhoneBook[x]);
            }

            foreach (var item in queries)
            {
                double value;

                if (phoneBook.TryGetValue(item, out value))
                {
                    result.Add($"{item}={value}");
                   // Console.WriteLine($"{item}={value}");
                }
                else
                {
                    result.Add("Not found");
                    //Console.WriteLine("Not found");
                }

            }

            return result;

        }
    }

    public class PersonDayFour
    {
        private int age;
        private static StringBuilder log = new StringBuilder();
        public PersonDayFour(int initialAge)
        {
            
            // Add some more code to run some checks on initialAge
            if (initialAge < 0)
            {
                string invalidAge = "Age is not valid, setting age to 0.";
                Console.WriteLine(invalidAge);
                PersonDayFour.Log = invalidAge;
                this.Age = 0;
            }
            else
            {
                this.Age = (initialAge <=30) ? initialAge : 30;
            }
            
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public static string Log
        {
            get => log.ToString();
            set => log.AppendLine(value);
        }

        public void AmIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (this.Age < 13)
            {
                const string young = "You are young.";
                Console.WriteLine(young);
                PersonDayFour.Log = young;
            }
            else if (Age < 18)
            {
                const string teenager = "You are a teenager.";
               Console.WriteLine(teenager);
               PersonDayFour.Log = teenager;
            }
            else
            {
                const string old = "You are old.";
                Console.WriteLine(old);
                PersonDayFour.Log = old;
            }
        }

        public void YearPasses()
        {
            // Increment the age of the person in here
            this.Age++;
        }

    }

    public class OperacaoDayFive
    {
        public int operA;
        public char operation;
        public int operB;
        public int operResult;
    }

}
