﻿using System;

namespace Example2
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
		public CA(int a, int b)
		{
			x = a;
			y = b;
			z = a + b;
		}
		public CA(int a, int b, int c)
		{
			x = a;
			y = b;
			z = c;
		}
	}

	class Program
    {
        static void Main(string[] args)
        {
			CA obj = new CA();
			Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
			CA obj1 = new CA(5, 7);
			Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj1.x, obj1.y, obj1.z);
			CA obj2 = new CA(5, 7, 25);
			Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj2.x, obj2.y, obj2.z);
		}
	}
}
