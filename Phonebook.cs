using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public static class Phonebook
    {
        public static void Run()
        {
            int listLength = Convert.ToInt32(Console.ReadLine());
            int i =0;
            Dictionary<string, string> dicPhoneBook = new Dictionary<string, string>(); 
            string[] pairs = new string[2];
            List<string> lstQuery = new List<string>();
            string query;

            while (i < listLength)
            {
                pairs = Console.ReadLine().Split(' ');
                dicPhoneBook.Add(pairs[0], pairs[1]);
                i++;
            }

            while (true)
            {
                query = Console.ReadLine();
                if (!String.IsNullOrEmpty(query))
                {
                    lstQuery.Add(query);
                }
                else
                    break;
            }

            GetNumbers(dicPhoneBook, lstQuery);

        }

        public static void GetNumbers(Dictionary<string, string> dicPhoneBook, List<string> lstQuery) 
        {
            foreach(string str in lstQuery)
            {
                if (!dicPhoneBook.ContainsKey(str))
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    Console.WriteLine(str + "=" + dicPhoneBook[str]);
                }
            }
            Console.ReadLine();
        }
    }
}
