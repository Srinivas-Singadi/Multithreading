using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        public static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
        }

        public static void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test2:" + i);
            }
            Console.WriteLine("Thread is going to sleep");
            Thread.Sleep(5000);

            Console.WriteLine("Thread Wake UP");
        }
        public static void Test3()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
        }

        static void Test4(Object max)
        {
            int num = Convert.ToInt32(max);

            for (int i = 0; i < num; i++)
            {

            }
        }
        static void Main(string[] args)
        {
            MethodsToExcute MT = new MethodsToExcute();
            Thread T1 = new Thread(MT.Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            T1.Start();
            T2.Start();
            T3.Start();

            Console.Read();
        }
    }
}
