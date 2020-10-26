using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public static class ArrayRotation
    {
        public static void Run()
        {
            int rotations = Convert.ToInt32(Console.ReadLine());
            //Array[] arr = 
            solution(new int[] { -1, -2, -3, -4, -5, -6 }, rotations);

        }

        public static int[] solution(int[] A, int K)
        {
            if (A.Length < 2)
                return A;

            int i = 0;
            int zeroIdx = getZerothIndex(A.Length, K);
            int[] arr = new int[A.Length];

            while (i < A.Length)
            {
                if ((zeroIdx+i) < A.Length)
                {
                    arr[i] = A[zeroIdx + i];
                }
                else
                {
                    arr[i] = A[(zeroIdx + i) - A.Length];
                }
                i++;
            }
            return arr;
        }

        public static int getZerothIndex(int length, int rotations)
        {
            int result = rotations;
            if (rotations > length)
            {
                while (result > length)
                {
                    result -= length;
                }
                result = length - result;
            }
            else
            {
                result = length - rotations;
            }

            return result;
        }
    }
}
