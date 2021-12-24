using System;
using System.Threading;
namespace Assignment3
{
    class Operations
    {
        public static void GetEvenNo()
        {
            Console.WriteLine("\t\t\t GetEvenNo() Started");
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(" Even : " + i); // Print even no
                    Thread.Sleep(100);                //Sleep 3 sec
                }
            }
        }

        public static void GetPallidromNo()
        {
            Console.WriteLine("\t\t\t GetPalindromeNo() Started");
            int num, n, rev_no, r;

            for (num = 1; num <= 1000; num++)
            {
                rev_no = 0;
                n = num;
                while (n != 0)
                {
                    r = n % 10;
                    rev_no = rev_no * 10 + r;
                    n = n / 10;
                }
                if (num == rev_no)
                {
                    Console.WriteLine("Palindrome : {0}", num);  // Print Pallindrom no
                    Thread.Sleep(100);                          //Sleep 3 sec
                }
            }
        }
    }
}