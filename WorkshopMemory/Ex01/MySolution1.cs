using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopMemory.Ex01
{
    public class MySolution1
    {
        delegate int Addition(int x, int y);
        public static void Start()
        {
            Addition add = Add;

            Random random = new Random();


            int v1 = random.Next(100); 
            int v2 = random.Next(100);

            Console.Write(add(v1, v2));
            
        }

        static int Add(int v1,int v2)
        {
            return v1 + v2;
        }
    }
}
