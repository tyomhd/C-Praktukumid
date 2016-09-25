using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum01
{
    class Inimene
    {
        private string _eesnimi;
        private string _perenimi;
        private DateTime _synniaeg;

        public string Eesnimi
        {
            get { return _eesnimi; }
            set { _eesnimi = value; }
        }
        public string Perenimi
        {
            get { return _perenimi; }
            set { _perenimi = value; }
        }

        public int Vanus
        {
            get { return (DateTime.Now.Date - _synniaeg.Date).Hours; }
        }
    }
}
