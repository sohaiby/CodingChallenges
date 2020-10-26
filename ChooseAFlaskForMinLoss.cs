using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public class ChooseAFlaskForMinLoss
    {
        //A robotic chemical delivery system for a college chemistry laboratory has been configured to work using only&nbsp;one type of glass flask per day. For each chemical ordered, it will be&nbsp;filled to a mark that is at least equal to the volume ordered. There are multiple flasks available, each with markings at various levels. Given a list of order requirements and a list of flasks with their measurements, determine the single type of flask that will result in minimal waste.&nbsp; Waste is the sum of&nbsp;

        public static void Run()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);            

            int requirementsCount = Convert.ToInt32(Console.ReadLine().Trim());
            int[] arrLength = new int[2] { 0, 0 };

            List<int> requirements = new List<int>();

            for (int i = 0; i < requirementsCount; i++)
            {
                int requirementsItem = Convert.ToInt32(Console.ReadLine().Trim());
                requirements.Add(requirementsItem);
            }

            int flaskTypes = Convert.ToInt32(Console.ReadLine().Trim());

            int markingsRows = Convert.ToInt32(Console.ReadLine().Trim());
            int markingsColumns = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> markings = new List<List<int>>();

            for (int i = 0; i < markingsRows; i++)
            {
                markings.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(markingsTemp => Convert.ToInt32(markingsTemp)).ToList());
            }

            int result = chooseFlask(requirements, flaskTypes, markings);

            //textWriter.WriteLine(result);
            
            //textWriter.Flush();
            //textWriter.Close();
        }

        public static int chooseFlask(List<int> requirements, int flaskTypes, List<List<int>> markings)
        {
            int wastage = -1;
            int fType = 0; int i = 0;
            int result; int minVal;
            List<int> lstResult = new List<int>();
            requirements = requirements.OrderBy(o => o).ToList();

            foreach (List<int> lstFType in markings)
            {
                if (fType != lstFType[0])
                {
                    if (wastage == -1)
                    {
                        lstResult.Add(Int32.MaxValue);
                    }
                    else
                    {
                        lstResult.Add(wastage);
                        wastage = -1;
                    }
                        i = 0;                    
                }

                for (; i < requirements.Count; i++)
                {
                    if (lstFType[1] >= requirements[i])
                    {
                        if (wastage == -1)
                        {
                            wastage = 0;
                        }
                        wastage += lstFType[1] - requirements[i];
                    }
                    else
                    {
                        break;
                    }
                }
                fType = lstFType[0];
            }

            if (wastage == -1)
            {
                lstResult.Add(Int32.MaxValue);
            }
            else
            {
                lstResult.Add(wastage);
            }

            //result = lstResult.Count > 0 ? lstResult.IndexOf(lstResult.Where(x => x >= 0).Min()) : -1;
            minVal = lstResult.Min();
            result = minVal != Int32.MaxValue ? lstResult.IndexOf(minVal) : -1;
            return result;
        }
    }
}
