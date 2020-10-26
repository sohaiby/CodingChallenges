using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public static class decodeString
    {
        public static void Run()
        {
            string decode = "";
            string code = "x3y4";            

            for (int i = 0; i < code.Length; i = i + 2)
            {
                int j = i + 1;
                for (int k = 0; k < Convert.ToInt32(code[j].ToString()); k++)
                {
                    decode += code[i];
                }
            }
            Console.Write(decode);
        }
    }
}
