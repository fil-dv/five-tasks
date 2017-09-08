using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_tasks
{
    class Task_3
    {
        public static List<UInt64> Fibo()
        {
            List<UInt64> list = new List<UInt64>();
            list.Add(0);
            list.Add(1);
            for (int i = 2; i < 101; i++)
            {
                list.Add(list[i - 1] + list[i - 2]);
            }
            return list;
        }
    }
}
