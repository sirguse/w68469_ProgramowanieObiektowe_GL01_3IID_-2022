using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość ciągu");
            int x = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine();
            for(int i = 0; i < x; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}