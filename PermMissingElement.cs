using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    /// <summary>
    /// Find the missing element in a given permutation.
    /// Array A consisting of N different integers.
    /// Array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.
    /// Find the missing element.
    /// </summary>
    static class PermMissingElement
    {
        public static void Run()
        {

        }

        public static int solution(int[] A)
        {
            int minVal;

            if (A == null || A.Length < 1)
                throw new Exception();
            else if (A.Length == 1)
            {
                if (A[0] != 1)
                    return A[0] - 1;
                else
                    return A[0] + 1;

            }
            else
            {
                minVal = A.Min();
                int maxVal = A.Max();
                for (int i = 0; i < A.Length; i++)
                {
                    if (minVal == A[i])
                    {
                        minVal++;
                        i = -1;
                    }
                }

                if (minVal < maxVal)
                    return minVal;
                else if (A.Min() == 1)
                    return maxVal + 1;
                else
                    return A.Min() - 1;
            }
        }
    }
}
