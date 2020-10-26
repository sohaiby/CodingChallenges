using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public static class SumOfIntegerDigits
    {
        public static void Run() 
        {
            Console.WriteLine(addTwoDigits(234));
        }

        static int addTwoDigits(int n)
        {
            int result = 0;
            if (n < 10)
            {
                return n;
            }
            result += addTwoDigits(n / 10);

            return result += n % 10;
        }

        static string addBinaryStrings(string a, string b)
        {
            string result = "";
            int sum = 0;

            int aLen = a.Length - 1;
            int bLen = b.Length - 1;

            while (aLen >= 0 || bLen >= 0 || sum == 1)
            {
                sum += ((aLen >= 0) ? a[aLen] - '0' : 0);
                sum += ((bLen >= 0) ? b[bLen] - '0' : 0);

                result = (char)(sum % 2 + '0') + result;

                sum /= 2;
                aLen--;
                bLen--;
            }

            return result;
        }



    }
}