using System;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = rand.Next(1, 11);
            Console.WriteLine("***Znajdz liczbe, masz 3 proby!");
            for (int i = 0; i < 3; i++)
            {
                int z = int.Parse(Console.ReadLine());
                if (z == x)
                {
                    Console.WriteLine("Znaleziono!!!");
                    break;

                }
                else
                {
                    Console.WriteLine("Znaleziono!!!");
                    break;
                }
            }
        }
    }
}