using System;

class Zadanie1
{
    static void Main()
    {
        Console.WriteLine("Sprawdzanie parzystosci liczb");
        Console.WriteLine();
        Console.WriteLine("Podaj liczbe");
        int liczba = int.Parse(Console.ReadLine());
        if(liczba%2 == 0)
        {
            Console.WriteLine("Jest parzysta");
        }
        else
        {
            Console.WriteLine("Jest nieparzysta");
        }


    }
}