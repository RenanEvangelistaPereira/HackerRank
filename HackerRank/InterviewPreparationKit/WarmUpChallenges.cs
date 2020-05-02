using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace br.com.techms.HackerRank.InterviewPreparationKit
{
    public class WarmUpChallenges
    {
        /// <summary>
        /// John works at a clothing store. He has a large pile of socks that he must pair by color for sale.
        /// Given an array of integers representing the color of each sock, determine how many pairs of socks
        /// with matching colors there are.
        /// For example, there are n=7 socks with colors ar=[1,2,1,2,1,3,2].There is one pair of color 1 and one of color 2.
        /// There are three odd socks left, one of each color. The number of pairs is 2.
        /// Function Description
        /// Complete the sockMerchant function in the editor below.It must return an integer representing the number
        /// of matching pairs of socks that are available.
        /// sockMerchant has the following parameter(s) :
        ///     n: the number of socks in the pile
        ///     ar: the colors of each sock
        /// </summary>
        /// <param name="n"></param>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static int SockMerchant(int n, int[] ar)
        {
            int result = 0;

            var res = ar
                .GroupBy(x => x)
                .Select(x => new { Sock = x.Key, Count = x.Count(), Pairs =  x.Count()/2})
                .Select(x => x.Pairs)
                .Sum();

            return result = res;
        }

        /// <summary>
        /// Gary is an avid hiker. He tracks his hikes meticulously, paying close attention to small details like topography.
        /// During his last hike he took exactly N steps. For every step he took, he noted if it was an uphill, U ,
        /// or a downhill, D step. Gary's hikes start and end at sea level and each step up or down represents a  unit
        /// change in altitude. We define the following terms:
        ///  - A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level
        ///    and ending with a step down to sea level.
        ///  - A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level
        ///    and ending with a step up to sea level.
        /// Complete the countingValleys function in the editor below. It must return an integer that denotes the
        /// number of valleys Gary traversed.
        /// </summary>
        /// <param name="n">the number of steps Gary takes</param>
        /// <param name="s">a string describing his path</param>
        /// <returns></returns>
        public static int CountingValleys(int n = 8, string s = "UDDDUDUU")
        {
            int result = 0;
            char[] stepsArray = s.ToCharArray();
            int arrLen = stepsArray.Length;
            int hills = 0;
            int level = 0;

            if (n != arrLen || arrLen < 2 || arrLen > 1000000)
            {
                string error = string.Empty;

                if (n != arrLen)
                {
                    error += "n and array elements count must be equal. ";
                }
                if (n < 2 || n > 1000000)
                {
                    error += "n must be between 2 and 1000000. ";
                }

                var res = stepsArray
                    .GroupBy(x => x)
                    .Select(x => new {id = x.Key, Count = x.Count()})
                    .Where(y => (y.id.Equals('U') || y.id.Equals('D')) == false)
                    .Select( x => x);

                if (res.Count() > 0)
                {
                    error += String.Format("Steps must be U or D only. You sent {0} unknow kinds of step.", res.Count());
                }


                throw new ArgumentException("Incorrect params detected. {0}", error);
            }
            else
            {

                foreach (var item in stepsArray)
                {
                    if (item == 'D')
                    {
                        level--;
                    }
                    else if (item == 'U')
                    {
                        int before = level;
                        level++;

                        if (level >= 0 && before < 0)
                        {
                            hills++;
                        }
                    }
                }

            }

            return result = hills;
        }
    }
}
