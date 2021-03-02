﻿using System;
using System.Text;

namespace Example1
{
    class MathOprt
    {
        public static double Mul2(double val)
        {
            return val * 2;
        }
        public static double Sqr(double val)
        {
            return val * val;
        }
    }
    delegate double DblOp(double x);

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            DblOp[] operation =
            {
                new DblOp(MathOprt.Mul2),
                new DblOp(MathOprt.Sqr)
            };

            for (int j = 0; j < operation.Length; j++)
            {
                Console.WriteLine("Резльтаты операции[{0}]:", j);
                Prc(operation[j], 4.0);
                Prc(operation[j], 9.94);
                Prc(operation[j], 3.143);
            }
        }

        static void Prc(DblOp act, double val)
        {
            double rslt = act(val);
            Console.WriteLine("Исходное значение {0}, результат  {1}", val, rslt);
        }

    }
}
