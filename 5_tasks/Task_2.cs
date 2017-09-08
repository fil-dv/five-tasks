using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_tasks
{
    class Task_2
    {
        public static ArrayList Union(List<int> listInt, List<char> listChar)
        {
            if (listInt.Count != listChar.Count)
            {
                throw new Exception("Lists count not equal.");
            }

            ArrayList resList = new ArrayList();
            for (int i = 0; i < listInt.Count; i++)
            {
                resList.Add(listInt[i]);
                resList.Add(listChar[i]);
            }
            return resList;
        }
    }
}
