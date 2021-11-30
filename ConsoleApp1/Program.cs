using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fNum=0, sNum = 0;
            Console.WriteLine("Enter First Number : ");
           var fN= Console.ReadLine();
            if (! int.TryParse(fN, out _))
            {
                Console.WriteLine("Please enter first Number: ");
                fN = Console.ReadLine();

            }
            fNum= Convert.ToInt32(fN);
           

            
            Console.WriteLine("Enter Second Number : ");
            var sN = Console.ReadLine();
            if (!int.TryParse(sN, out _)) 
            {
                Console.WriteLine("Please enter second Number: ");
                sN = Console.ReadLine();

            }
            sNum = Convert.ToInt32(sN);
            Console.WriteLine("Sum Of {0} and {1} is : {2}",fNum,sNum,ClassLibrary1.Class1.Sum(fNum,sNum));
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
