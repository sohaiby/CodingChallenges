using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public static class firstNonRepeatingCharacter
    {
        public static void Run()
        {
            string someArr = "abacabacd";

            char result = firstNotRepeatingCharacter(someArr);
            Console.WriteLine(result);
        }

        static char firstNotRepeatingCharacter(string s) 
        {
            char val = '_';
            int idx = 0;
            int sLen = s.Length - 1;

            for(int i = 0; i <= sLen; i++)
            {
                if (i == sLen || s.Remove(i, 1).IndexOf(s[i]) == -1)
                {
                    val = s[i];
                    break;
                }
            }

            return val;
        }
    }
}
