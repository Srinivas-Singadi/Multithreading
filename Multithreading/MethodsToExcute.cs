using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class MethodsToExcute
    {
        public void Test1()
        {
            for (int i = 0; i <=100 ; i++)
            {
                Console.WriteLine("Method Excuted form Method Test1:" + i);
            }
        }

        public void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Method Excuted form Method Test2:" + i);
            }
        }
        public void Test3()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Method Excuted form Method Test3:" + i);
            }
        }
    }
}
