using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Xml;
//using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Test_Programs
{
    public class GetRequestMostActiveAuthors
    {

        public static void Run()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int threshold = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> result = getUsernames(threshold);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }

        /*
         * Complete the 'getUsernames' function below.
         *
         * The function is expected to return a STRING_ARRAY.
         * The function accepts INTEGER threshold as parameter.
         */

        public static List<string> getUsernames(int threshold)
        {
            List<string> lstAuthors = new List<string>();
            PageInfo pInfo;
            AuthorInfo authInfo;
            JArray dataArray = new JArray();
            int pageno = 1;

            while (true)
            {
                string url = "https://jsonmock.hackerrank.com/api/article_users?page=" + pageno.ToString();
                string json = HttpGet(url);
                dynamic obj = JsonConvert.DeserializeObject(json);
                pInfo = new PageInfo();
                pInfo.page = obj.page;
                pInfo.perPage = obj.per_page;
                pInfo.totalUsers = obj.total;
                pInfo.totalPages = obj.total_pages;

                authInfo = new AuthorInfo();
                dataArray = (JArray)obj["data"];

                for (int i = 0; i < dataArray.Count; i++)
                {
                    authInfo.username = dataArray[i]["username"].ToString();
                    authInfo.submission_count = Convert.ToInt32(dataArray[i]["submission_count"]);

                    if (authInfo.submission_count > threshold)
                    {
                        lstAuthors.Add(authInfo.username);
                    }
                }

                if (pInfo.page == pInfo.totalPages)
                {
                    break;
                }
                else
                {
                    pageno++;
                }
            }
            return lstAuthors;
        }

        public static string HttpGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            try
            {
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);

                    return reader.ReadToEnd();
                }
            }
            finally
            {
                response.Close();
            }
        }

    }

    public class PageInfo
    {

        public string page { get; set; }
        public string perPage { get; set; }
        public string totalUsers { get; set; }
        public string totalPages { get; set; }
        public AuthorInfo authorInfo;
    }

    public class AuthorInfo
    {
        public string id { get; set; }
        public string username { get; set; }
        public string about { get; set; }
        public string submitted { get; set; }
        public string updated_at { get; set; }
        public int submission_count { get; set; }
        public int comment_count { get; set; }
        public string created_at { get; set; }
    }
}
