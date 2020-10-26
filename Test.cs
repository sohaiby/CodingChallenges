using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    static class Test
    {
        public static void Run() 
        {
            string[] arr = null;


            int loops = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < loops; i++)
            {
                arr = Console.ReadLine().Split(' ');
            }

            for (int j = 0; j < arr.Length; j = j + 3)
            {
                //Console.WriteLine(
            }
        }

        internal static int getResult(string one, string two, long n)
        {
            IList<long> fcount = new List<long>();
            long oneInt = one.Length;
            long twoInt = two.Length;
            fcount.Add(oneInt);
            fcount.Add(twoInt);
            int result = -1;
            do
            {
                fcount.Add(oneInt + twoInt);
                oneInt = twoInt;
                twoInt = fcount[fcount.Count - 1];
            } while (twoInt < n);

            int i = fcount.Count - 3;
            int currentIndex = i;
            while (i >= 0)
            {
                long current = fcount[i];
                if (n > current)
                {
                    n = n - current;
                    i--;
                    currentIndex = i;
                }
                else
                {
                    if (i == 0)
                    {
                        result = one[(int)n - 1];
                    }
                    if (i == 1)
                    {
                        result = two[(int)n - 1];
                    }
                    i = currentIndex - 2;
                    currentIndex = i;
                }
            }
            if (result == -1)
            {
                result = two[(int)n - 1];
            }
            return (result - 48);
        }


        #region oneForLoopInsteadTwo
        /// <summary>
        /// Use of one for loop for each item in an array 
        /// against every other item in the array. Usually
        /// nested loops would be used to achieve this.
        /// </summary>
        public static void oneForLoopInsteadTwo()
        {
            int[] arr = new int[] { 5, 7, 3, 4, 2 };
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == j)
                    continue;

                //do some logic
                Console.WriteLine(arr[i].ToString() + "," + arr[j].ToString());

                if (i == arr.Length -1 && j == arr.Length - 1)
                {
                    break;
                }
                else if (i == arr.Length - 1)
                {
                    i = -1;
                    j++;
                }
                    
            }
        }
        #endregion

        #region Generics

        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int[] intArray = new int[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        intArray[i] = Convert.ToInt32(Console.ReadLine());
        //    }

        //    n = Convert.ToInt32(Console.ReadLine());
        //    string[] stringArray = new string[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        stringArray[i] = Console.ReadLine();
        //    }

        //    PrintArray<Int32>(intArray);
        //    PrintArray<String>(stringArray);
        //}

        //static void PrintArray(T[] lst)
        //{

        //}

        #endregion
    }

    #region Inheritance and abstraction
    /*
    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }

    //Write MyBook class
    class MyBook : Book
    {
        protected int price;

        //if there's no constructor with 0 argument in the base class, then
        // you must either call the base constructor explicitly, or define
        // 0 argument constructor on base class
        public MyBook(String t, String a, int p) : base(t, a)
        {
            this.title = t;
            this.author = a;
            this.price = p;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Author: " + this.author);
            Console.WriteLine("Price: " + this.price);
        }
    }

    class Solution
    {
        static void Main(String[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
     */
    // Inheritance and abstraction
    #endregion

}
