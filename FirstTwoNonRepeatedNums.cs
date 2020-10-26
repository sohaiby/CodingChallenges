using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public class FirstTwoNonRepeatedNums
    {
        public static void Run()
        {
            string[] strInput = Console.ReadLine().Split(' ');
            List<int> lstResult = getFirstTwoItemsWithoutPair(new List<int>(Array.ConvertAll(strInput, strTemp => 
                Convert.ToInt32(strTemp))));            
        }

        public static List<int> getFirstTwoItemsWithoutPair(List<int> list)
        {
            int num, repeat;
            List<int> lstResult = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                num = list[i];

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (num == list[j])
                    {
                        lstResult.Add(num);
                        break;
                    }
                }
                if (lstResult.Count == 2)
                {
                    break;
                }
            }

            return lstResult;
        }
    }
}
