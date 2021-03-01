using System;

namespace Example1
{
    class Cmin
    {
        public static int min(int x, int y)
        {
            int z = (x < y) ? x : y;
            return z;
        }
        public static int minabs(ref int x, ref int y)
        {
            x = (x < 0) ? -x : x;
            y = (y < 0) ? -y : y;
            int z = (x < y) ? x : y;
            return z;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = -4;
            int b = 2;
            Console.WriteLine("a={0}  b={1}", a, b);
            int k = Cmin.min(a, b);
            Console.WriteLine("a={0}  b={1}", a, b);
            Console.WriteLine("k=" + k);
            k = Cmin.minabs(ref a, ref b);
            Console.WriteLine("a={0}  b={1}", a, b);
            Console.WriteLine("k=" + k);
        }
    }
}
