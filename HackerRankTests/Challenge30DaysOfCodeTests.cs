using Microsoft.VisualStudio.TestTools.UnitTesting;
using br.com.techms.HackerRank;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace br.com.techms.HackerRank.Tests
{
    [TestClass()]
    public class Challenge30DaysOfCodeTests
    {
        [TestMethod()]
        public void DayTwoTest()
        {
            double meal_cost = 12.00;   //Convert.ToDouble(Console.ReadLine());
            int tip_percent = 20;       //Convert.ToInt32(Console.ReadLine());
            int tax_percent = 8;        //Convert.ToInt32(Console.ReadLine());

            int result = Challenge30DaysOfCode.DayTwo(meal_cost, tip_percent, tax_percent);

            Assert.AreEqual(15, result);
        }

        [TestMethod()]
        public void DayThreeTest()
        {
            // input n => 1 <= n <= 100
            int n0 = 3;
            int n1 = 24;

            // out put
            string expectedOut0 = "Weird";
            string expectedOut1 = "Not Weird";


            // Sample Case 0 -> n0 <- expectedOut0
            Assert.AreEqual(expectedOut0, Challenge30DaysOfCode.DayThree(n0));

            // Sample Case 1 -> n1 <- expectedOut1
            Assert.AreEqual(expectedOut1, Challenge30DaysOfCode.DayThree(n1));

        }

        [TestMethod()]
        public void DayFourTest()
        {
            //s.Count(c => (c == '\n'))
            string result = Challenge30DaysOfCode.DayFour(4, new int[] { -1, 10, 16, 18 });
            int lines = result.Count(c => (c == '\r'));
            Assert.AreEqual(13, lines);

        }

        [TestMethod()]
        public void DayFiveTest()
        {
            int n = 2;//Convert.ToInt32(Console.ReadLine());

            List<OperacaoDayFive> returnDayFive = Challenge30DaysOfCode.DayFive(n);

            foreach (var item in returnDayFive)
            {
                Console.WriteLine($"{item.operB} {item.operation} {item.operA} = {item.operResult }");
            }

            Assert.AreEqual(10, returnDayFive.Count);

        }

        [TestMethod()]
        public void DaySixTest()
        {
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int nL = 0; nL < n; nL++)
            //{
            //    char[] charArr = (Console.ReadLine()).ToCharArray();

            //    int lenTempS = charArr.Length;

            //    string leftWord = string.Empty;
            //    string rightWord = string.Empty;

            //    for (int i = 0; i < lenTempS; i++)

            //        if (i % 2 == 0)
            //        {
            //            leftWord = leftWord + charArr[i].ToString();
            //        }
            //        else
            //        {
            //            rightWord = rightWord + charArr[i].ToString();
            //        }

            //    Console.WriteLine($"{leftWord} {rightWord}");

            //}

            int n = 2;


            if (n > 10)
            {
                throw new Exception("Exceed limit of 10");
            }

            string[] inputStrings = new string[2] { "Racker", "Rank" };

            List<string> result = Challenge30DaysOfCode.DaySix(n, inputStrings);

            Assert.AreEqual(n, result.Count);

        }

        [TestMethod()]
        public void DaySevenTest()
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 4;

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] arr = Array.ConvertAll("1 4 3 2".Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int[] reverse = Challenge30DaysOfCode.DaySeven(arr);

            Console.WriteLine(string.Join(" ", reverse));

            Assert.AreEqual(arr.Length, reverse.Length);



        }

        [TestMethod()]
        public void DayEightTest()
        {
            int numberOfEntries = 3;
            List<string> phoneBookEntries = new List<string>() { "sam 99912222", "tom 11122222", "harry 12299933" };
            List<string> queriesForPhoneBook = new List<string>() { "sam", "edward", "harry" };

            List<string> result = Challenge30DaysOfCode.DayEight(numberOfEntries, phoneBookEntries, queriesForPhoneBook);

            Assert.AreEqual(numberOfEntries, result.Count);

        }

        [TestMethod()]
        public void DayNineTest()
        {
            int n = 3;
            Assert.AreEqual(6, Challenge30DaysOfCode.DayNine(n));
        }

        [TestMethod()]
        public void DayTenTest()
        {
            int n = 439;
            int count = Challenge30DaysOfCode.DayTen(n);

            Console.WriteLine($"{n} --> {count}");

           

        }
    }
}