using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    /// <summary>
    /// Cloud is an array of int with values 0 and 1. You can either jump with +1 or +2.
    /// You may only jump into 0 cloud and avoid the 1 cloud. 
    /// Count the minimum number of jumps needed to reach the end
    /// First input is total no. of clouds
    /// Second input is cloud values, either 0 or 1, separated by space
    /// </summary>
    public class JumpingOnClouds
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = Jumps(c);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        public int Jumps(int[] c)
        {
            int jumps = 0; int position = 0; int length = c.Length - 1;

            for (; position < length; )
            {
                if (position + 2 <= length && c[position + 2] == 0)
                {
                    position += 2;
                }
                else
                {
                    position += 1;
                }
                jumps += 1;
            }

            return jumps;
        }
    }
}
