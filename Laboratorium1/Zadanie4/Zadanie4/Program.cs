using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***OBLICZANIE SILNI***");
            Console.WriteLine();
            Console.WriteLine("Podaj liczbe");

            int liczba = int.Parse(Console.ReadLine());
            int silnia = 1;
            Console.Clear();
            for (int i =1; i<= liczba; i++)
            {
                silnia *= i;

            }
            Console.WriteLine("Wynik: "+silnia);

        }

    }
}