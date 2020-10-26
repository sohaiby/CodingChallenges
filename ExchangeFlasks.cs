using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    /// <summary>
    /// A seller purchases some fiiled flasks with his budget and can get some more filled flasks by returning empty flasks.
    /// Find out with a given budget, how many total filled flasks he could get
    /// </summary>
    public class ExchangeFlasks
    {
        public static void Run()
        {
            int remainder, onHand;
            Console.WriteLine("Enter Budget <space> FlaskValue <space> ExchangeQty");

            List<int> lstInput = Array.ConvertAll(Console.ReadLine().Split(' '), arr => Convert.ToInt32(arr)).ToList<int>();
            int totalFlasks = lstInput[0] / lstInput[1];
            onHand = totalFlasks;
            do
            {
                onHand = Math.DivRem(onHand, lstInput[2], out remainder);
                totalFlasks += onHand;
                onHand += remainder;

            } while (onHand >= lstInput[2]);

            Console.WriteLine("Total Flasks: " + totalFlasks.ToString());
        }
    }
}
