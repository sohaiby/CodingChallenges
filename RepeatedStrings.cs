using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    /// <summary>
    /// Find the number of repeated character of a substring in the whole string.
    /// The substring is repeated n number of times.
    /// The first input is the substring.
    /// The second input is the total length of the string.
    /// For example, if the string s=abcac and n=10, the substring we consider is 'abcacabcac', the first  characters of th infinite string. There are 4 occurrences of a in the substring.
    /// </summary>
    public class RepeatedStrings
    {
        public void Run() 
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        static long repeatedString(string s, long n)
        {
            
            long numOfA = 0;

            long numOfStr = n / s.Length;
            long rem = n % s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    numOfA++;
                }
            }

            numOfA *= numOfStr;

            for (int j = 0; j < rem; j++)
            {
                if (s[j] == 'a')
                {
                    numOfA++;
                }
            }

            return numOfA;
        }
    }
}
