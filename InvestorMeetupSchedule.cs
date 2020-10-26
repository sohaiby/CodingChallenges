using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Test_Programs
{
    public class InvestorMeetupSchedule
    {
        public static void Run()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int firstDayCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> firstDay = new List<int>();

            for (int i = 0; i < firstDayCount; i++)
            {
                int firstDayItem = Convert.ToInt32(Console.ReadLine().Trim());
                firstDay.Add(firstDayItem);
            }

            int lastDayCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> lastDay = new List<int>();

            for (int i = 0; i < lastDayCount; i++)
            {
                int lastDayItem = Convert.ToInt32(Console.ReadLine().Trim());
                lastDay.Add(lastDayItem);
            }

            int result = countMeetings(firstDay, lastDay);

            Console.WriteLine(result.ToString());
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static int countMeetings(List<int> firstDay, List<int> lastDay)
        {
            // 1. Pick first invenstor. Check how many no. of days available
            // 2. If Only one day available = Schedule meeting (m++)
            // 3. If more than one day available, then pick all the avilable dates. for e.g n =3
            // 4. Search for an investor who has only one date available in between those days
            // 5. Schedule meeting with that investor (m++)
            // 5.1 Remove the investor from both lists
            // 6. Reduce the available days for investor 1 (n=2)
            // 7. Go to step 4 again
            // 8. If no investor found, Goto step 5

            //Logic:
            // Check if the day is >= to list1 day and <= to list2 day and not exist in ListBlocked
            // Add the the blocked days in ListBlocked

            int value; //var result = null;
            List<int> lstBlocked = new List<int>();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < firstDay.Count; i++)
            {
                dict.Add(i, lastDay[i] - firstDay[i] + 1);
            }

            var orderedDict = dict.OrderBy(key => key.Value);

            foreach (KeyValuePair<int, int> kvp in orderedDict)
            {
                value = Enumerable.Range(firstDay[kvp.Key], lastDay[kvp.Key] - firstDay[kvp.Key] + 1).Except(lstBlocked).FirstOrDefault();
                if (value != 0)
                {
                    lstBlocked.Add(value);
                }
            }

            //for (int i = 0; i < firstDay.Count; )
            //{
            //    if (firstDay[i] == lastDay[i])
            //    {
            //        if (!lstBlocked.Contains(firstDay[i]))
            //        {
            //            lstBlocked.Add(firstDay[i]);
            //            firstDay.RemoveAt(i);
            //            lastDay.RemoveAt(i);
            //            continue;
            //        }
            //        else
            //        {
            //            firstDay.RemoveAt(i);
            //            lastDay.RemoveAt(i);
            //        }
            //    }
            //    else
            //    {
            //        int j = i + 1;
            //        if (firstDay.Count > j)
            //        {
            //            for (; j < firstDay.Count; j++)
            //            {
            //                if (firstDay[j] == lastDay[j] && firstDay[j] >= firstDay[i] && firstDay[j] <= lastDay[i])
            //                {
            //                    if (!lstBlocked.Contains(firstDay[j]))
            //                    {
            //                        lstBlocked.Add(firstDay[j]);
            //                        firstDay.RemoveAt(j);
            //                        lastDay.RemoveAt(j);
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        firstDay.RemoveAt(j);
            //                        lastDay.RemoveAt(j);
            //                        break;
            //                    }
            //                }
            //            }
                            
            //                {
            //                    if (!lstBlocked.Contains(firstDay[i]))
            //                    {
            //                        lstBlocked.Add(firstDay[i]);
            //                        firstDay.RemoveAt(i);
            //                        lastDay.RemoveAt(i);
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        firstDay.RemoveAt(i);
            //                        lastDay.RemoveAt(i);
            //                        break;
            //                    }
            //                }
            //        }
            //        else
            //        {
            //            for (int k = firstDay[i]; k <= lastDay[i]; k++)
            //            {
            //                if (!lstBlocked.Contains(k))
            //                {
            //                    lstBlocked.Add(k);;
            //                    break;
            //                }                            
            //            }
            //            firstDay.RemoveAt(i);
            //            lastDay.RemoveAt(i);
            //        }
            //    }
            //}

            return lstBlocked.Count;
        }

    }
}
