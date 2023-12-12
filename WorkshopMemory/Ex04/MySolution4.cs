namespace WorkshopMemory.Ex04
{
    public class MySolution4
    {
        public static void Start()
        {
            A a = new A();
            B b = new B();

            delg ds = a.ma;
            delg[] dt = [a.ma,b.mb];
            delg dm = a.ma;
            dm += b.mb;

            a.ma();
            b.mb();
            Console.WriteLine();
            ds();
            Console.WriteLine();
            foreach (var d in dt)
                d();
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
