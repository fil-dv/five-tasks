using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_tasks
{
    class Task_1
    {
        public static int Method_1(List<int> list)
        {
            int res = 0;
            for (int i = 0; i < list.Count; i++)
            {
                res += list[i];
            }
            return res;
        }

        public static int Method_2(List<int> list)
        {
            int res = 0;
            int count = 0;
            while (count < list.Count)
            {
                res += list[count++];                
            }
            return res;
        }

        public static int Method_3(List<int> list)
        {
            int res = 0;
            int count = 0;
            
            int result = RecursCalc(list, ref res, count);
            return result;
        }

        static int RecursCalc(List<int> list, ref int res, int counter)
        {
            if (counter < list.Count)
            {
                res += list[counter];
                RecursCalc(list, ref res, ++counter);
            }

            return res;
        }
    }
}
