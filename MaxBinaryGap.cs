using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    /// <summary>
    /// BinaryGap
    /// Find longest sequence of zeros in binary representation of an integer.
    /// 529 = 1000010001 = 4 max binary gap (MBG)
    /// 20 = 10100 = 1 MBG
    /// 15 = 1111 = 0 MBG
    /// </summary>
    public static class MaxBinaryGap
    {
        public static void Run()
        {
            int input = 328;
            int result = FindBinaryGap(input);

            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        public static int FindBinaryGap(int N)
        {
            //328 = 101001000
            int result = 0;
            int buffer = 0;

            string binary = Convert.ToString(N, 2);

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    buffer = 0;
                    for (int j = i + 1; j < binary.Length; j++)
                    {
                        if (binary[j] == '0')
                        {
                            buffer++;
                        }
                        else
                        {
                            i = j - 1;
                            if (buffer > result)
                            {
                                result = buffer;
                            }
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}
