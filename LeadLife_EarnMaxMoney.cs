using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public class LeadLife_EarnMaxMoney
    {
        public static void Run()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int earningCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> earning = new List<int>();

            for (int i = 0; i < earningCount; i++)
            {
                int earningItem = Convert.ToInt32(Console.ReadLine().Trim());
                earning.Add(earningItem);
            }

            int costCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> cost = new List<int>();

            for (int i = 0; i < costCount; i++)
            {
                int costItem = Convert.ToInt32(Console.ReadLine().Trim());
                cost.Add(costItem);
            }

            int e = Convert.ToInt32(Console.ReadLine().Trim());

            int result = calculateProfit(n, earning, cost, e);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static int calculateProfit(int n, List<int> earning, List<int> cost, int e)
        {
            int money =0;

            for (int i = 0; i < n; i++)
            {
                if (i + 1 != n)
                {
                    if (earning[i] > cost[i])
                    {
                        money += earning[i] * e;
                        money -= cost[i] * e;
                    }
                }
                else
                {
                    money += earning[i] * e;
                }
            }

            return money;
        }
    }
}
