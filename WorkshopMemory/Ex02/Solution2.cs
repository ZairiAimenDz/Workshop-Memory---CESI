using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopMemory.Ex02
{
    public class Solution2
    {
        public static void Start()
        {
            Func<int,int> Square = x => x * x;
            Console.WriteLine(Square(2));
        }
    }
}
