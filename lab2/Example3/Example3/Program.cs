using System;

namespace Example3
{
    class Program
    {
        class Rmas
        {
            protected float[] msf = new float[10];
            public float this[int j]
            {
                get
                {
                    return msf[j];
                }
                set
                {
                    msf[j] = value;
                }
            }

        }

        static void Main(string[] args)
        {
            Rmas obj = new Rmas();
            for (int i = 0; i < 10; i++)
            {
                obj[i] = (float)1.5 * i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0, 4}", obj[i]);
            }

        }
    }
}
