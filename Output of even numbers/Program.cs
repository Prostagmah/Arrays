using System;

namespace hz_lol
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[500];
            for (int i = 0; i < 500; i++)
            {
                a[i] = rnd.Next();
            }
            for (int i = 0; i < 500; i++)
            {
                if (a[i]%2 == 0)
                {
                    Console.WriteLine(a[i] + "");
                }
            }
            Console.ReadKey();
        }
    }
}