using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopMemory.Ex04
{
    public class Solution4
    {
        public static void Start()
        {
            A a;
            B b;

            delg d;
            delg[] ds;
            delg dm;

            a = new A();
            b = new B();

            d = a.ma;
            ds = [a.ma,b.mb];
            dm = a.ma;
            dm += b.mb;

            a.ma();
            b.mb();

            d();
            foreach (var di in ds)
            {
                di();
            }
            dm();

            dm -= b.mb;
            dm();
        }

        public delegate void delg();

        class A
        {
            public void ma()
            {
                Console.WriteLine("ma");
            }
        }
        class B
        {
            public void mb()
            {
                Console.WriteLine("mb");
            }
        }
    }
}
