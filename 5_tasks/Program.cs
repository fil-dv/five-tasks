using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;


namespace _5_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTask_1();
            Console.WriteLine("-----------------");
            TestTask_2();
            Console.WriteLine("-----------------");
            TestTask_3();
            Console.WriteLine("-----------------");
            TestTask_4();
            Console.WriteLine("-----------------");
           // TestTask_5();
            Console.WriteLine("-----------------");
        }

        static void TestTask_5()
        {
            DateTime dt1 = DateTime.Now;
            Task_5.StrBuilder100();
            DateTime dt2 = DateTime.Now;
            Console.WriteLine(dt2 - dt1);
        }

        static void TestTask_4()
        {
            List<uint> list = new List<uint> { 45, 15, 32, 9, 78};
            uint res = Task_4.Replacer(list);
            Console.WriteLine(res);
        }

        static void TestTask_3()
        {
            List<BigInteger> list = Task_3.Fibo();
            try
            {                
                for(int i = 0; i < list.Count; ++i)
                {
                    if (i == list.Count - 1) Console.WriteLine("{0}) {1}. ", i, list[i]);
                    else  Console.WriteLine("{0}) {1}, ", i, list[i]);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
        }

        static void TestTask_2()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<char> list2 = new List<char> { 'a', 'b', 'c', 'd', 'e' };
            try
            {
                ArrayList res = Task_2.Union(list1, list2);
                foreach (var item in res)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void TestTask_1()
        {
            List<int> list = new List<int> { 1, 3, 5, 7, 9 };

            int res1 = Task_1.Method_1(list);
            Console.WriteLine("Method 1  = {0}", res1);

            int res2 = Task_1.Method_2(list);
            Console.WriteLine("Method 2  = {0}", res2);

            int res3 = Task_1.Method_3(list);
            Console.WriteLine("Method 3  = {0}", res3);
        }
    }
}
