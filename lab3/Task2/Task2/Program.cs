using System;
using System.Text;

namespace Task2
{
    class CA
    {
        public int x, y, z;
        public readonly int rd;
        public CA(int x, int y, int a) :this(a)
        {
            z = x + y;
            rd = x + y + z;

        }
        public CA(int a)
        {
            if (a >= 0 && a <= 10)
            {
                rd = a; 
            }
            else if (a < 1)
            {
                 Console.WriteLine("Присваиваемое значение выходит за диапазон значений ");
                rd = 0;
            }
            else
            {
                Console.WriteLine("Присваиваемое значение выходит за диапазон значений ");
                rd = 10;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            CA test1 = new CA(-1);
            CA test2 = new CA(7);
            CA test3 = new CA(11);
        }
    }
}
