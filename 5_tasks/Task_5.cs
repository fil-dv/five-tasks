using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5_tasks
{
    class Task_5
    {
        public static string StrBuilder100()
        {
            List<string> listRes = new List<string>();
            string result = "";
            int count = 0;
            MyRes mr = new MyRes();
            do
            {
                mr = Calc();
                if (mr.IntRes == 100)
                {
                    if (!listRes.Contains(mr.StrRes))
                    {
                        listRes.Add(mr.StrRes);
                    }
                    //Console.WriteLine("{0}) {1} = {2}", count, mr.StrRes, mr.IntRes);
                }
                if (++count > 70000) break;
            }
            while (true);// (mr.IntRes != 100); 
            int counter = 0;
            foreach (var item in listRes)
            {
                counter++;
                Console.WriteLine("{0}) {1} = 100;", counter, item);
            }
            return result;            
        }

        static MyRes Calc()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            MyRes myRes = new MyRes();
            bool isFirst = true;
            for(int i = 0; i < list.Count; ++i)
            {
                Thread.Sleep(1);
                Random rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
                int iRnd = rnd.Next(0, 3);
                switch (iRnd)
                {
                    case 0:
                        myRes.IntRes += list[i];
                        if (isFirst)
                        {
                            myRes.StrRes = myRes.StrRes + list[i].ToString();
                            isFirst = !isFirst;
                        }
                        else
                        {
                            myRes.StrRes = myRes.StrRes + "+" + list[i].ToString();
                        }
                        break;
                    case 1:
                        
                        if (isFirst)
                        {
                            myRes.IntRes = list[i];
                            myRes.StrRes = myRes.StrRes + list[i].ToString();
                            isFirst = !isFirst;
                        }
                        else
                        {
                            myRes.IntRes -= list[i];
                            myRes.StrRes = myRes.StrRes + "-" + list[i].ToString();
                        }
                        break;
                    default:
                        if (i < list.Count - 1)
                        {
                            //if (list[i] * 10 + list[i + 1] > 123) break;
                            list[i + 1] = list[i] * 10 + list[i + 1];
                        }
                        else
                        {
                            Thread.Sleep(1);
                            Random r = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
                            int ir = rnd.Next(0, 2);
                            if (ir == 0)
                            {
                                myRes.IntRes += list[i];
                                myRes.StrRes = myRes.StrRes + "+" + list[i].ToString();
                            }
                            else
                            {
                                myRes.IntRes -= list[i];
                                myRes.StrRes = myRes.StrRes + "-" + list[i].ToString();
                            }
                        }
                        break;
                }
            }
            return myRes;            
        }
    }

    class MyRes
    {
        public int IntRes { get; set; }
        public string StrRes { get; set; }
    }
}
