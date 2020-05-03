using Microsoft.VisualStudio.TestTools.UnitTesting;
using br.com.techms.HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}