using System;
using System.IO;
using System.Linq;
using System.Threading;
namespace Assignment3
{
    class ThreadingDemo
    {
        public static bool isThreading = false;
        public static int WaitTime = 1000;
        public static bool IsMultipleThreading = false;
        public static bool IsComplete = false;
        public static void Main(string[] args)
        {
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("../.././Threading_N_File_Assignment_Output.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("Processing....Please wait");
            Console.SetOut(writer);
            Console.WriteLine("\n Without Threading");
            PrintEvenNumbers();
            PrintPalindromeNumbers();
            Console.WriteLine("\n=========================================");
            Console.WriteLine("\n With Single Thread");
            isThreading = true;
            PrintEvenNumbers();
            PrintPalindromeNumbers();
            Console.WriteLine("\n=========================================");
            Console.WriteLine("==============================================");
            Console.WriteLine("\n With two Threads");
            Thread even = new Thread(PrintEvenNumbers);
            Thread palindrome = new Thread(PrintPalindromeNumbers);
            IsMultipleThreading = true;
            even.Start();
            palindrome.Start();
            // Console.SetOut(writer);
            Console.SetOut(oldOut);
            //writer.Flush();
            writer.Close();
            ostrm.Close();
            if (IsComplete)
            {
                Console.WriteLine($"Done!! Output logged in the file:'Threading_N_File_Assignment_Output.txt'");
            }
            Console.ReadLine();
        }
        
        public static void PrintEvenNumbers()
        {
            Console.WriteLine("Even Numbers from 1 to 1000=>");
            for (int p = 0; p <= 1000; p += 2)
            {
                Console.WriteLine("Even Number : " + p);
                if (IsMultipleThreading && p==1000) {
                    IsComplete = true;
                }
                if (isThreading)
                {
                    Thread.Sleep(WaitTime);
                }
            }
        }
        public static void PrintPalindromeNumbers()
        {
            //Console.WriteLine("Palindrome Numbers from 1 to 10000=>");
            for (int k = 1; k <= 10000; k++)
            {
                string data = k.ToString();
                bool isPalindrome = true;
                for (int j = 0; j < data.Length / 2; j++)
                {
                    if (data[j] != data[(data.Length - 1) - j])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome)
                {
                    //if (k > 1)
                    //    Console.Write(", ");
                    Console.WriteLine("Palindrome Number=" + k);
                    if (isThreading)
                    {
                        Thread.Sleep(WaitTime);
                    }
                }
            }
        }
        public static void PrintPalindromeNumber1()
        {
            for (int pl = 1; pl <= 100; pl++) 
            {
                
                char[] pl_char = pl.ToString().ToCharArray();
               string rev_pl= pl_char.Reverse<char>().ToArray().ToString();
                if (pl == Convert.ToInt32(rev_pl)) 
                {
                    Console.WriteLine("Palindrome Number=" + pl);
                    if (isThreading)
                    {
                        Thread.Sleep(WaitTime);
                    }
                }
            }
        }
    }
}
