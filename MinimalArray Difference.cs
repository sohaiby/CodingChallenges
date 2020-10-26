using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public class MinimalArray_Difference
    {
        public static void Run()
        {
            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => Convert.ToInt32(tmp));
            Console.WriteLine(solution(A).ToString());
            //Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int result = 0, difference = 0;
            int leftSum = 0, rightSum = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                leftSum += A[i];
                rightSum = 0;
                for (int j = i + 1; j < A.Length; j++)
                {
                    rightSum += A[j];
                }

                difference = Math.Abs((leftSum) - (rightSum));
                if (i == 0 || result > difference)
                    result = difference;

            }

            return result;
        }
    }
}
