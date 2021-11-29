using System;

namespace Output_of_numbers_from_a_in_forward_and_reverse_order
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
            for (int z = 499; z>=0; z--)
            {
                Console.WriteLine(a[z]);
            }
            for (int y = 0; y <= 499; y++)
            {
                Console.WriteLine(a[y]);
            }
            Console.ReadKey();
        }
    }
}