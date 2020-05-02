using Microsoft.VisualStudio.TestTools.UnitTesting;
using br.com.techms.HackerRank.InterviewPreparationKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace br.com.techms.HackerRank.InterviewPreparationKit.Tests
{
    [TestClass()]
    public class WarmUpChallengesTests
    {
        /// <summary>
        /// Sample Input
        /// 9
        /// 10 20 20 10 10 30 50 10 20
        /// </summary>
        [TestMethod()]
        public void SockMerchantTest()
        {
            int n = 9;
            string inputString = "10 20 20 10 10 30 50 10 20";

            int[] ar = Array.ConvertAll(inputString.Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = WarmUpChallenges.SockMerchant(n, ar);

            Console.WriteLine(result);

            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CountingValleysTest()
        {
            int[] results = new int[3];

            results[0] = WarmUpChallenges.CountingValleys(8, "UDDDUDUU");
            results[1] = WarmUpChallenges.CountingValleys(16, "UDDDUDUUUDDDUDUU");
            results[2] = WarmUpChallenges.CountingValleys(24, "UDDDUDUUUDDDUDUUUDDDUDUU");

            Console.WriteLine(results.ToString());

            Assert.AreEqual(Convert.ToInt32(6), Convert.ToInt32(results.Sum()));
        }
    }
}