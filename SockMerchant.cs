using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    /// <summary>
    /// Each number represent a unique sock.
    /// Search how many unique pair of socks do the merchant have to sale
    /// First input is total number of socks
    /// Second input is the sock numbers (or type of sock) separated by spaces
    /// </summary>
    public class SockMerchant
    {

        public void Run()
        {
             int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = getPairs(n, ar);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int getPairs(int n, int[] ar)
        {
            int pairs = 0;

            List<int> lstPairs = new List<int>();

            foreach (var num in ar.GroupBy(x => x))
            {
                lstPairs.Add(num.Count());
            }

            foreach (int socks in lstPairs)
            {
                pairs += socks / 2;
            }

            return pairs;

        }
    }
}
