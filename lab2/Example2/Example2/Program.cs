using System;

namespace Example2
{
    class Program
    {
        class CStatic
        {
            private int m = 35;
            public int y
            {
                get
                {
                    return m;
                }

                set
                {
                    m = value;
                }
            }
        }

        static void Main(string[] args)
        {
            CStatic p = new CStatic();
            Console.WriteLine("{0}", p.y);
            p.y = 75;
            int z = p.y;
            Console.WriteLine("{0}", z);
        }
    }
}
