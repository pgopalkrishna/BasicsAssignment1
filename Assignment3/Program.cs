using System;
using System.Threading;
namespace Assignment3
{
    class Program
    {
        public static bool isThreading = false;
        public static bool isMultiThread = false;
        public static int WaitTime = 3000;
        //static void Main(string[] args)
        //{
        //    Console.Clear();
        //    var watch = System.Diagnostics.Stopwatch.StartNew();
        //     watch.Start();
        //    // Without Threading
        //    Console.WriteLine("\n ===================== Without Threading ===================== \n ");
        //    PrintEvenNumbers();
        //    Console.WriteLine("\n ========================================== \n ");
        //    PrintPalindromeNumbers();
        //    Console.WriteLine("\n\n ====================== With single thread ==================== \n ");
        //    isThreading = true;
        //    // With single thread
        //    PrintEvenNumbers();
        //    Console.WriteLine("\n \n ========================================== \n ");
        //    PrintPalindromeNumbers();
        //    //With 2 Threads
        //    Console.WriteLine("\n\n =================== With two Threads ======================= \n ");
        //    Thread PrintEvenThread = new Thread(new ThreadStart(PrintEvenNumbers));
        //    Thread PrintPalindromeThread = new Thread(new ThreadStart(PrintPalindromeNumbers));
        //    isMultiThread = true;
        //    PrintEvenThread.Start();
        //    PrintPalindromeThread.Start();
        //    PrintEvenThread.Abort();
        //    PrintPalindromeThread.Abort();
        //    Console.WriteLine("\n ===================== END===================== \n ");
        //    watch.Stop();
        //    Console.WriteLine($"Threads aborted!!,Execution time: {watch.Elapsed}");
        //    Console.ReadLine();
        //}
        public static void PrintEvenNumbers()
        {
            Console.WriteLine("\n Even Numbers from 1 to 1000=>\n");
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) == 0)
                {
                    if (i > 1)
                        Console.Write(", ");
                    Console.Write("Even Number : " + i);
                    if (isThreading)
                    {
                        Thread.Sleep(WaitTime);
                    }
                }
            }
        }
        public static void PrintPalindromeNumbers() 
        {
            Console.WriteLine("\n Palindrome Numbers from 1 to 10000=> \n");
            for (int k = 1; k <= 1000; k++)
            {
                string data = k.ToString();
                bool isPalindrome = true;
                for (int i = 0; i < data.Length / 2; i++)
                {
                    if (data[i] != data[(data.Length - 1) - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome)
                {
                    if (k > 1)
                        Console.Write(", ");
                    Console.Write("Palindrome Number=" + k);
                    if (isThreading && isMultiThread)
                    {
                        Thread.Sleep(WaitTime);
                    }
                }
            }
        }
        //With Single Thread
        //With Two Threads
        // File Assignment:log file
    }
}
