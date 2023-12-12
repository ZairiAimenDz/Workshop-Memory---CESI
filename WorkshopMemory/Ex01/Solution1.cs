using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopMemory.Ex01
{
    public class Solution1
    {
        delegate int SumDelegate(int a, int b);
        public static void Start()
        {
            SumDelegate sumDelegate = Sum;
            Console.WriteLine(sumDelegate(1, 2));
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
