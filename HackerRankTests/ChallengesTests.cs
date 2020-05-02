using br.com.techms.HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace br.com.techms.HackerRank.Tests
{
    [TestClass()]
    public class ChallengesTests
    {
        [TestMethod()]
        public void PlusMinusTest()
        {

            IList<string> result = Challenges.PlusMinus(new int[] { -4, 3, -9, 0, 0, 4, 1, 0, });
            int expectedSize = 3;
            Assert.AreEqual(expectedSize, result.Count);

        }

        [TestMethod()]
        public void StaircaseTest()
        {
            Challenges.Staircase(9);
        }

        [TestMethod()]
        public void MiniMaxSumTest()
        {
            string outputString = Challenges.MiniMaxSum(new[] { 1, 2, 3, 4, 5, 1000000000 });
            string expectedString = "15 1000000014";

            Assert.AreEqual(expectedString, outputString);
        }

        [TestMethod()]
        public void TimeConversionTest()
        {
            string inputString = "09:05:57PM";
            string outputString = Challenges.TimeConversion(inputString);
            string expectedString = "21:05:57";
            Assert.AreEqual(expectedString, outputString);
        }

        [TestMethod()]
        public void GradingStudentsTest()
        {
            int qtde = 4;
            string inputString   = "73 67 38 33";
            string expectedValue = "75 67 40 33";

            int gradesCount = Convert.ToInt32(qtde);

            List<int> grades = inputString.Split(' ').Select(Int32.Parse).ToList(); 

            //for (int i = 0; i < gradesCount; i++)
            //{
            //    int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            //    grades.Add(gradesItem);
            //}

            List<int> result = Challenges.GradingStudents(grades);

            string output = String.Join(" ", result);

            Assert.AreEqual(expectedValue, output, false);

        }
    }
}