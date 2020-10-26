using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    /// <summary>
    /// You are on sea level. Below sea level are valleys. Above sea level are mountains
    /// You take step down (D) to go to a valley. You take step up (U) to go to mountain
    /// Count how many valleys you've been into in your journey
    /// First input is number of steps you took
    /// Second input is yout Step type, U for Step up, D for step down without any space
    /// </summary>
    public class CountingValleys
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = NumberOfValleys(n, s);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        public int NumberOfValleys(int n, string s)
        {
            int valleys = 0; int steps = 0; int lastStep = 0;
            List<string> lstStep = new List<string>();

            for (int i = 0; i < n; i++)
            {
                lastStep = steps;

                if (s[i] == 'U')
                {
                    steps += 1;
                }
                else if (s[i] == 'D')
                {
                    steps -= 1;
                }

                if (lastStep == -1 && steps == 0)
                {
                    valleys += 1;
                }
            }

            return valleys;
        }
    }
}
