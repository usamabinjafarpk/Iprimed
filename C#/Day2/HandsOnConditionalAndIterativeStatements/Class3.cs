using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalAndIterativeStatements
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int m1 = 79, m2 = 80, m3 = 79;
            int total=m1+m2+m3;
            float avg=(total/3);
            string res = null;
            if(avg > 70)
            {
                res = "Pass";
            }
            else
            {
                res = "Fail";
            }
            if(res == "Fail")
            {
                Console.WriteLine("U r fail");
            }
            else
            {
                Console.WriteLine($"U r pass tmark={total} percentage={avg}%");
            }
        }
    }
}
