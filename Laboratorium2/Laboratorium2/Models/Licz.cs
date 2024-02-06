using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2.Models
{
    public class Licz
    {
        private int _wartosc;

        public Licz(int wartosc)
        {
            _wartosc = wartosc;
        }
        public void Dodaj(int add)
        {
            _wartosc += add;
        }
        public void Odejmij(int sub)
        {
            _wartosc -= sub;
        }
        public int getWartosc()
        {
            return _wartosc;
        }
    }
}
