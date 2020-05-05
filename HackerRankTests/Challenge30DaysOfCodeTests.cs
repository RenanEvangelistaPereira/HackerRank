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
            string result = Challenge30DaysOfCode.DayFour(4, new int[] {-1, 10, 16, 18});
            int lines = result.Count(c => (c == '\r'));
            Assert.AreEqual(13, lines);

        }
    }
}