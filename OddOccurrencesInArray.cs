using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    /// <summary>
    /// Find value that occurs in odd number of elements
    /// </summary>
    public static class OddOccurrencesInArray
    {
        public static void Run() 
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), buf => Convert.ToInt32(buf));
            Console.WriteLine(FindNumber(arr).ToString());
        }

        static int FindNumber(int[] arr)
        {
            int oddNumber = 0;
            int occurrences = 0;
            int checker;

            for (int i = 0; i < arr.Length; i++)
            {
                checker = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                        continue;

                    if (checker == arr[j])
                    {
                        occurrences++;
                    }
                }

                if (occurrences % 2 != 0)
                {
                    oddNumber = arr[i];
                    break;
                }
                occurrences = 1;
            }

            return oddNumber;
        }
    }
}
