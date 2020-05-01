using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace br.com.techms.HackerRank
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int sumMainCol = 0, sumSecCol = 0;
            int sizeArray = arr.Count;
            int posCol = sizeArray - 1;

            for (int x = 0; x < sizeArray; x++)
            {
                var tempLine = arr[x];

                for (int y = 0; y < sizeArray; y++)
                {

                    int celValue = arr[x][y]; //tempLine[y];    

                    if (celValue <= 100 && celValue >= -100)
                    {
                        if (x == y)
                        {
                            sumMainCol += celValue;

                        }

                        if (y == posCol)
                        {
                            sumSecCol += celValue;
                            posCol--;
                        }

                    }
                    else
                    {
                        throw new ArgumentException("Cel value must be between -100 and 100!");
                    }
                }
                tempLine.Clear();
            }

            //return Math.Abs(Math.Abs(sumMainCol) - Math.Abs(sumSecCol));
            return Math.Abs(sumMainCol - sumSecCol);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
