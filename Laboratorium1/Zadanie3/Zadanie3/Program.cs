using System;
using System.ComponentModel;
/* W tym zadaniu zrobię prosty kalkulator z podstawowym menu */
namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe");
            Console.WriteLine();
            Console.WriteLine("Dodawanie: 1");
            Console.WriteLine("Odejmowanie: 2");
            Console.WriteLine("Mnozenie: 3");
            Console.WriteLine("Dzielenie: 4");

            int x = int.Parse(Console.ReadLine());
            Console.Clear();
            if (x == 1)
            {
                Console.WriteLine("***DODAWANIE***");
                Console.WriteLine();
                Console.WriteLine("Podaj 1 liczbe:");
                int liczba1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj 2 liczbe:");
                int liczba2 = int.Parse(Console.ReadLine());

                int wynik = liczba1 + liczba2;
                Console.WriteLine();
                Console.WriteLine("Wynik to: " + wynik);


            }
            if (x == 2)
            {
                Console.WriteLine("***ODEJMOWANIE***");
                Console.WriteLine();
                Console.WriteLine("Podaj 1 liczbe:");
                int liczba1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj 2 liczbe:");
                int liczba2 = int.Parse(Console.ReadLine());

                int wynik = liczba1 - liczba2;
                Console.WriteLine();
                Console.WriteLine("Wynik to: " + wynik);
            }
            if (x == 3)
            {
                Console.WriteLine("***MNOZENIE***");
                Console.WriteLine();
                Console.WriteLine("Podaj 1 liczbe:");
                int liczba1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj 2 liczbe:");
                int liczba2 = int.Parse(Console.ReadLine());

                int wynik = liczba1 * liczba2;
                Console.WriteLine();
                Console.WriteLine("Wynik to: " + wynik);
            }
            if (x == 4)
            {
                Console.WriteLine("***DODAWANIE***");
                Console.WriteLine();
                Console.WriteLine("Podaj licznik:");
                int liczba1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj mianownik:");
                int liczba2 = int.Parse(Console.ReadLine());

                int wynik = liczba1 / liczba2;
                Console.WriteLine();
                Console.WriteLine("Wynik to: " + wynik);
            }
        }
    }
}