using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _5_tasks
{
    class Task_3
    {
        public static List<BigInteger> Fibo()
        {            
            List<BigInteger> list = new List<BigInteger>();
            try
            {                               
                list.Add(0);
                list.Add(1);
                for (int i = 2; i < 100; i++)
                {                    
                    BigInteger big = (BigInteger)list[i - 1] + (BigInteger)list[i - 2];
                    list.Add(big);
                }                
            }
            catch (OverflowException ex)
            {  
                Console.WriteLine("step {0}, error - {1}", list.Count, ex.Message);
            }
            return list;
        }
    }
}
