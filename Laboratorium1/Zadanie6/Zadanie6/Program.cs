using System;
using System.ComponentModel;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***KALKULATOR JEDNOSTEK MIARY***");
            Console.WriteLine();
            Console.WriteLine("Podaj co chcesz obliczyc");
            Console.WriteLine();
            Console.WriteLine("Celsiusza na Fahrenheita: 1");
            Console.WriteLine();
            Console.WriteLine("Metry na Centymetry: 2");
            Console.WriteLine();
            int x = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("***KALKULATOR JEDNOSTEK MIARY***");
            if (x == 1)
            {
                Console.WriteLine("Podaj stopnie Celsjusza");
                int liczba = int.Parse(Console.ReadLine());

                int wynik = (int)((liczba * 1.8) + 32);
                Console.WriteLine(wynik);

            }
            if (x == 2)
            {
                Console.WriteLine("Podaj metry");
                int liczba = int.Parse(Console.ReadLine());
                int wynik = (liczba * 100);
                Console.WriteLine(wynik);
            }

        }
    }
}