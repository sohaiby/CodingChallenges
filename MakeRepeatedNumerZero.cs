using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;

namespace Test_Programs
{
    public class MakeRepeatedNumerZero
    {
        //Input:  [1 , 3, 5, 3, 7, 88, 96, 99, 88, 7, 7, 1, 0, 5]
        //Output:  [1 , 3, 5, 0, 7, 88, 96, 99, 0, 0, 0, 0, 0, 0]

        public static void Run()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Ar => Convert.ToInt32(Ar));
            int[] result = SetRepeatedAsZero(arr);

            foreach (int i in result)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadLine();
        }

        public static int[] SetRepeatedAsZero(int[] A) 
        {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                    {
                        A[j] = 0;
                    }
                }
            }
            return A;
        }        
    }
}
