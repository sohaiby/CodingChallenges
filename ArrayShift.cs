using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public static class ArrayShift
    {
        public static void Run() 
        {
            string result =string.Empty;
            int Idx = 0, total = 5;
            int useCases = Convert.ToInt32(Console.ReadLine());
            List<int[]> lstParamet = new List<int[]>();
            List<int[]> lstArr = new List<int[]>();
        
            for(int i=0; i < useCases; i++)
            {

            lstParamet.Add(Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray());
            lstArr.Add(Console.ReadLine().Split(' ').Select(y => Convert.ToInt32(y)).ToArray());
            }

            for(int j=0; j < lstArr.Count; j++)
            {
                total = lstParamet[j][0];
                Idx = lstParamet[j][1];
                for (int k = 0; k < total; k++)
                {
                    if(Idx == 0)
                    {
                        Idx = total;
                    }
                    result += lstArr[j][Math.Abs(total - Idx)].ToString() + " ";
                    Idx--;
                }
                result = result.Remove(result.Length - 1);
                Console.WriteLine(result);
                result = string.Empty;
            }
        }
    }
}
