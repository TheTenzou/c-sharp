using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Strings = new string[255];
            Console.Write("String count: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Strings[i] = Console.ReadLine();
            }
            
            Console.Write("Enter substring: ");
            string str_find = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (Strings[i].IndexOf(str_find) != -1)
                {
                    Console.WriteLine(i + 1 + ": " + Strings[i]);
                }
            }
        }
    }
}
