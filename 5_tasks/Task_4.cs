using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_tasks
{
    class Task_4
    {
        public static uint Replacer(List<uint> list)
        {            
            List<string> listStr = new List<string>();

            foreach (var item in list)
            {
                listStr.Add(Convert.ToString(item));
            }
            //List<string> listNew = new List<string>();
            listStr.Sort((a,b) => b[0].CompareTo(a[0]));
            string str = "";
            foreach (var item in listStr)
            {
                str = str + item;
            }
            
            return Convert.ToUInt32(str);
        }
    }
}
