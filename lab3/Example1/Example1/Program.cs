using System;

namespace Example1
{
    class Program
    {
        class CA
        {
            public int x, y, z;
            public CA()
            {
                x = 3;
                y = 2;
                z = x + y;
            }

        }

        static void Main(string[] args)
        {
            CA obj = new CA();
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
        }
    }
}
