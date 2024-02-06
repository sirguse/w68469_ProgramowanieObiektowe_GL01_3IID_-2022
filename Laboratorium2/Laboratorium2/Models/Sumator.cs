using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2.Models
{
     public class Sumator
    {
        private int[] Liczby; 
        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }
        public int Suma()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                suma += liczba;
            }
            return suma;
        }
        public int SumaPodziel3()
        {
            int suma = 0;
            foreach(int liczba in Liczby)
            {
                if (liczba % 3 == 0)
                {
                    suma += liczba;
                }
            }
            return suma;
        }
        

        public int IleElementow2() 
        {
            foreach(int liczba in Liczby)
            {
                Console.WriteLine(liczba);
            }
            return Liczby.Length;


        }

        public void WypiszElementyWZakresie(int lowIndex, int highIndex)
        {
            for (int i = Math.Max(0, lowIndex); i < Math.Min(Liczby.Length, highIndex + 1); i++)
            {
                Console.Write(Liczby[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

