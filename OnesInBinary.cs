using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    /// <summary>
    /// find and print the base-10 integer denoting the maximum number of consecutive 1's in n's binary representation.
    /// </summary>
    public static class OnesInBinary
    {
        public static void Run()
        {
            int input = Convert.ToInt32(Console.ReadLine()); //439;
            int result = FindMaxOnesInBinary(input);

            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        public static int FindMaxOnesInBinary(int N)
        {
            //439 = 110110111
            int result = 0;
            int buffer = 0;

            string binary = Convert.ToString(N, 2);

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    buffer = 1;
                    for (int j = i + 1; j < binary.Length; j++)
                    {
                        if (binary[j] == '1')
                        {
                            buffer++;
                        }
                        else
                        {
                            i = j;                            
                            break;
                        }
                    }
                    if (buffer > result)
                    {
                        result = buffer;
                    }
                }
            }

            return result;
        }
    }
}
