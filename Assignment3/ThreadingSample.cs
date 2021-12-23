using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment3
{
    class ThreadingSample
    {
        //public static void Main(string[] args) {
            
        //    Thread t1 = new Thread(new ThreadStart(Method1));
        //    Thread t2 = new Thread(new ThreadStart(Method2));
        //    t1.Start();
            
        //    t2.Start();
        //    t1.Abort();
        //    t2.Abort();
        //    Console.ReadLine();
        //}
        public static void Method1() {
            for (int i = 0; i <=10; i++) {
                Console.WriteLine("Hello John _"+i+1);
                Thread.Sleep(3000);
                Console.WriteLine("=================");
            }
        }
        public static void Method2()
        {
            for (int i = 10; i <=20; i++)
            {
                Console.WriteLine("Hello Jenny _" + i+1);
                Thread.Sleep(3000);
            }
        }
        
    }
}
