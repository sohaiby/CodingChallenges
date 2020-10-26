using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public static class NewYearChaos
    {
        public static void Run()
        {

        }

        // Complete the oddNumbers function below.
        static List<int> oddNumbers(int l, int r)
        {
            List<int> lstOdd = new List<int>();

            for (; l <= r; l++)
            {
                if (l % 2 != 0)
                {
                    lstOdd.Add(l);
                }
            }

            return lstOdd;
        }

        public static List<string> sortDates(List<string> dates)
        {
            List<DateTime> lstDates = new List<DateTime>();
            List<string> lstOutput = new List<string>();

            foreach (string s in dates)
            {
                lstDates.Add(Convert.ToDateTime(s));
            }
            lstDates.Sort((a, b) => a.CompareTo(b));

            foreach (DateTime d in lstDates)
            {
                lstOutput.Add(d.Date.ToString());
            }

            return dates;
        }
    }
}
