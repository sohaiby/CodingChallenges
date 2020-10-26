using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public static class SumOfXYDivisibles
    {
        public static void Run()
        {
            Console.WriteLine(GetSum(1000));
            
        }

        public static int GetSum(int n)
        {
            n = n - 1;
            int x = 3;
            int y = 5;
            int z = x * y;

            int buf1 = x * ((n / x) * ((n / x) + 1) / 2);
            int buf2 = y * ((n / y) * ((n / y) + 1) / 2);
            int buf3 = z * ((n / z) * ((n / z) + 1) / 2);

            return buf1 + buf2 - buf3;
        }
    }
}
