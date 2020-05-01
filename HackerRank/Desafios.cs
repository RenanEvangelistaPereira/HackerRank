﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace br.com.techms.HackerRank
{
    public class Desafios
    {
        // Complete the plusMinus function below.
        public static IList<string> PlusMinus(int[] arr)
        {
            int total;
            try
            {
                total = arr.Length;
                int qtdeIrreg = arr
                    .Where(t => t > 100 || t < -100)
                    .Select(t => t)
                    .Count();

                if (total < 0 || qtdeIrreg > 0)
                {
                    throw new ArgumentException("Array Length must be between 0 and 100");
                }
                else if (total == 0)
                {
                    Console.WriteLine(Decimal.Zero.ToString("N6"));
                    Console.WriteLine(Decimal.Zero.ToString("N6"));
                    Console.WriteLine(Decimal.Zero.ToString("N6"));
                    return null;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            IList<string> result = new List<string>();

            

            //int qtdeNeg = arr.Select((v, i) => new { i, v })
            //    .Where(t => t.v < 0)
            //    .Select(t => t.i)
            //    .Count();
            //int qtdeZero = arr.Select((v, i) => new { i, v })
            //    .Where(t => t.v == 0)
            //    .Select(t => t.i)
            //    .Count();
            //int qtdePos = arr.Select((v, i) => new { i, v })
            //    .Where(t => t.v > 0)
            //    .Select(t => t.i)
            //    .Count();

            int qtdeNeg = arr
                .Where(t => t < 0)
                .Select(t => t)
                .Count();

            int qtdeZero = arr
                .Where(t => t == 0)
                .Select(t => t)
                .Count();

            int qtdePos = arr
                .Where(t => t > 0)
                .Select(t => t)
                .Count();

            Decimal ratiosPos = (Decimal)qtdePos / total;
            Decimal ratiosNeg = (Decimal)qtdeNeg / total;
            Decimal ratiosZero = (Decimal)qtdeZero / total;

            

            //Debug.Print();
            Console.WriteLine(ratiosPos.ToString("N6"));
            Console.WriteLine(ratiosNeg.ToString("N6"));
            Console.WriteLine(ratiosZero.ToString("N6"));

            result.Add(ratiosPos.ToString("N6"));
            result.Add(ratiosNeg.ToString("N6"));
            result.Add(ratiosZero.ToString("N6"));


            /*
             var arrayTemp = (from element in arr orderby element ascending select element).ToArray();


             var arrayTempZero = arrayTemp.Select((s, i) => new {i, s})
                 .Where(t => t.s == 0)
                 .Select(t => t.i)
                 .ToList();
            */




            return result;

        }

        public static void Staircase(int n)
        {
            if (n > 0 && n <= 100)
            {
                StringBuilder staircase = new StringBuilder();

                
               // char padLeft = ' ';
               // char padRight = '#';

                for (int x = 0; x < n; x++)
                {
                    string tmpLinha = String.Empty;

                    for (int z = 0; z < (n - x - 1); z++)
                    {
                        tmpLinha += " ";
                    }

                    for (int y = 0; y < x+1 ; y++)
                    {
                        tmpLinha += "#";
                    }



                    //tmpLinha.PadLeft(n, );
                    //tmpLinha.PadLeft((n - x - 1));
                    //tmpLinha.PadRight(n, padRight);

                    staircase.AppendLine(tmpLinha);
                }

                Console.WriteLine(staircase.ToString());
            }
            else
            {
                throw new ArgumentException("N must be between 0 and 100");
            }

        }

        // Complete the miniMaxSum function below.
        public static void MiniMaxSum(int[] arr)
        {

            {
                int lenArr = arr.Length | 0;
                long somaMin = 0;
                long somaMax = 0;

                try
                {
                    int qtdeIrreg = arr
                        .Where(t => t > 1000000000 || t < 1)
                        .Select(t => t)
                        .Count();

                    if (qtdeIrreg > 10000)
                    {
                        throw new ArgumentException("Array members must be between 1 and 1.000.000.000");
                    }


                    //var arrayTemp = (from element in arr orderby element ascending select element).ToArray();


                    long[] arrayTemp = Array.ConvertAll<int, long>((from element in arr orderby element ascending select element).ToArray(),
                        delegate (int i)
                        {
                            return (long)i;
                        });

                    if (lenArr == 1)
                    {
                        somaMin += arr[0];
                        somaMax += arr[0];
                    }
                    else if (lenArr == 2)
                    {
                        somaMin += arr[0];
                        somaMax += arr[1];
                    }
                    else
                    {
                        somaMin = arrayTemp.Select((v, i) => new { i, v })
                            .Where(t => t.i < lenArr - 1)
                            .Select(t => t.v)
                            .ToList().Sum();

                        somaMax = arrayTemp.Select((v, i) => new { i, v })
                            .Where(t => t.i > 0)
                            .Select(t => t.v)
                            .ToList().Sum();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    //throw;
                }

                Console.WriteLine("{0} {1}", somaMin, somaMax);
            }
        }

        public static int BirthdayCakeCandles(int[] ar)
        {
            int result = 0;
            int lenAr = ar.Length;
            int maxAr = ar.Max();
            int minAr = ar.Min();

            int qtdeIrreg = ar
                .Where(t => t > 10000000 || t < 1)
                .Select(t => t)
                .Count();

            if (lenAr < 1 || lenAr > (10 ^ 5))
            {
                throw new ArgumentException("Array members must be between 1 and 100.000");
            }
            else if (qtdeIrreg > 0)
            {
                return ar.Where(n => n <= 10000000 && n >= 1)
                    .Select(n => n)
                    .Where(t => t == maxAr)
                    .Select(t => t)
                    .Count();   

                // throw new ArgumentException("Array members values must be between 1 and 10.000.000");
            }
            else
            {
                if (maxAr == minAr)
                {
                    result = Convert.ToInt32(lenAr);
                }

                //countExeptMax
                result =  ar
                        .Where(t => t == maxAr)
                        .Select(t => t)
                        .Count();
            }
            return result;
        }

        public static string TimeConversion(string s = "07:05:45PM")
        {
            string result = string.Empty;

            DateTime d = DateTime.Parse(s);
            result = d.ToString("HH:mm:ss");

            return result;
        }

        /*
 * Complete the jumpingRooks function below.
 */
        public static int JumpingRooks(int k, string[] board)
        {
            int result = 0;


            return result;
        }
    }
}
