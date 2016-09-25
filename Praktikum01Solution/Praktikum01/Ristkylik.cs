using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum01
{
    class Ristkylik
    {
        private int _laius;
        private int _pikkus;


        public Ristkylik(int laius, int pikkus)
        {
            _laius = laius;
            _pikkus = pikkus;
        }

        public int arvutaPindala()
        {
            return _laius*_pikkus;
        }

        public bool kasOnRuut()
        {
            return _laius/_pikkus == 1;
        }

        public bool kasOnVordsed(Ristkylik rk)
        {
            return this.arvutaPindala() == rk.arvutaPindala();
        }
    }
}
