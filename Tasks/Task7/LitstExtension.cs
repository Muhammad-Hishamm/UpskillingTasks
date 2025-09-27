using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal static class LitstExtension
    {
        public static double AverageEvenNumbers(this List<int> list)
        {
            double evenSum = 0;
            int evenCnt = 0;
            foreach(int item in list)
            {
                if (item % 2 == 0)
                {
                    evenSum += item;
                    evenCnt++;
                }
            }
            return evenSum / evenCnt;
        }
    }
}
