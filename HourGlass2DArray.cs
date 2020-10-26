using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    /// <summary>
    /// Given a 6x6 array [arr], We define an hourglass in A to be a subset of values with indices falling in this pattern in arr's graphical representation
    /// An hourglass is like
    /// a b c
    ///   d
    /// e f g
    /// There are 16 hourglasses in [arr], and an hourglass sum is the sum of an hourglass' values. Calculate the hourglass sum for every hourglass in [arr], then print the maximum hourglass sum.
    /// The input is 6x6 values, where row values are separated by space, and column values separated by Return (Enter)
    /// For e.g.
    /// 1 1 1 0 0 0
    /// 0 1 0 0 0 0 
    /// 1 1 1 0 0 0
    /// 0 0 0 4 2 0
    /// 0 0 0 2 4 2
    /// 0 0 0 0 2 4
    /// </summary>
    public static class HourGlass2DArray
    {
        public static void Run() 
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = MaxSumOfHourGlass(arr);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        static int MaxSumOfHourGlass(int[][] arr) 
        {
            int sum = 0, maxSum = 0, lastSum = 0;

            for (int k = 0; k < 4; k++)
            {
                for (int l = 0; l < 4; l++)
                {
                    sum = 0;
                    for (int i = k; i < k+3; i++)
                    {                        
                        for (int j = l; j < l+3; j++)
                        {
                            if (i == k + 1 && (j ==l || j == l+2))
                            {
                                continue;
                            }
                            else
                            {
                                sum += arr[i][j];
                            }
                        }
                    }

                    if (sum > maxSum || (l == 0 && k == 0))
                    {
                        maxSum = sum;
                    }
                }
            }

            return maxSum;
        }
    }
}
