using System;
using System.Text;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите ваше имя");
            string str = Console.ReadLine();
            Console.WriteLine("Привет " + str + "!!!");
            Console.WriteLine("Введите  один символ с клавитуры");
            int kod = Console.Read();
            char sim = (char)kod;
            Console.WriteLine("Код символа  " + sim + " = " + kod);
            Console.WriteLine("Код символа  {0} = {1}", sim, kod);
            int s1 = 255;
            int s2 = 32;
            Console.WriteLine(" \n{0,5}\n+{1,4}\n-----\n{2,5}", s1, s2, s1 + s2);
            Console.WriteLine(" \n{1,5}\n+{0,4}\n-----\n{2,5}", s1, s2, s1 + s2);
            double sum1 = 500.3467;
            double sum2 = 43.5;
            Console.WriteLine(" \n{0,10:P2}\n+{1,9:P2}\n-----\n{2,10:P2}", sum1, sum2, sum1 + sum2);
        }
    }
}
