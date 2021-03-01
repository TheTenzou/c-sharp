using System;

namespace Task1
{
    class Program
    {
        class CA
        {
            public int x, y, z;
            public readonly int rd;
            public CA(int x, int y,  int a) : this(a)
            {
                z = x + y;
                rd = x + y + z;

            }
            public CA(int a)
            {
                rd = a;
            }
        }

        static void Main(string[] args)
        {
            CA[] arr = new CA[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = new CA(i);
                Console.WriteLine("arr[{0}] = {1}", i, arr[i].rd);
            }

        }
    }
}
