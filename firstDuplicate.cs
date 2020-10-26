using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public static class firstDuplicate
    {
        public static void Run()
        {
            int[] someArr = new int[5] { 1, 2, 3, 4, 5 };

            int result = findFirstDuplicate(someArr);
            Console.WriteLine(result);
        }

        static int findFirstDuplicate(int[] a)
        {
            HashSet<int> hSet = new HashSet<int>();
            foreach (int item in a)
            {
                if (!hSet.Add(item))
                {
                    return item;
                }
            }

            return -1;
        }
    }
}
