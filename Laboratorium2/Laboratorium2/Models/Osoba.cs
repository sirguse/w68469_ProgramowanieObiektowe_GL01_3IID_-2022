using LAB2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2.Models
{
    public class Osoba
    {
        private string Imie;
        private string Nazwisko;
        private int Wiek;
        private Samochod samochod;

        public string Dane
        {
            get { return Imie + "" + Nazwisko; }
        }
        public Osoba(string Imie, string Nazwisko, int Wiek)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Wiek = Wiek;
        }
        public bool SprawdzWiek()
        {
            return Wiek >= 18;
        }

        public void ZmienNazwisko(string Nowe_Nazwisko)
        {
            Nazwisko = Nowe_Nazwisko;
        }
        public void UstawSamochod(Samochod samochod)
        {
            this.samochod = samochod;
        }
    }
}
