using br.com.techms.HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace br.com.techms.HackerRank.Tests
{
    [TestClass()]
    public class DesafiosTests
    {
        [TestMethod()]
        public void PlusMinusTest()
        {

            IList<string> result = Desafios.PlusMinus(new int[] { -4, 3, -9, 0, 0, 4, 1, 0, });
            int expectedSize = 3;
            Assert.AreEqual(expectedSize, result.Count);

            //Assert.Fail();
        }

        [TestMethod()]
        public void StaircaseTest()
        {
            Desafios.Staircase(9);

            //Assert.Fail();
        }

        [TestMethod()]
        public void MiniMaxSumTest()
        {
            Desafios.MiniMaxSum(new[] { 1, 2, 3, 4, 5, 1000000000 });
            //Assert.Fail();
        }

        [TestMethod()]
        public void TimeConversionTest()
        {
            //Assert.Fail();

            Desafios.TimeConversion("09:05:57PM");
        }
    }
}