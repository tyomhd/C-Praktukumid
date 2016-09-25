using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Luua meetod, mis küsib kasutaja käest arvu ning teeb seda seni kaua, kuni kasutaja on andnud korrektse sisendi
            // KysiKasutajaltArv("Palun sisesta number:");

            //Luua meetod, mis küsib kasutajalt vanust ning tagastab, kas tegemist on täisealise kasutajaga
            bool vanusekontroll = KasOnaisealine(KysiKasutajaltArv("Palun sisestage oma vanus:"));


        }
        //Luua meetod, mis küsib kasutaja käest arvu ning teeb seda seni kaua, kuni kasutaja on andnud korrektse sisendi
        ////1. Mida peaks meetid tagastama?
        //Taisarv(int)
        //2.Mis on meetodi nimi?
        //KysiKasutajaltArv
        //3.Kas meetod vajab sisendparametrid?
        //jah
        static int KysiKasutajaltArv(string tekst)
        {
            Console.WriteLine(tekst);
            string vastus = Console.ReadLine();
            int a;
            if (int.TryParse(vastus, out a) == true)
            {
                return a;
            }
            else
            {
                return KysiKasutajaltArv(tekst);
            }
        }

        //Luua meetod, mis küsib kasutajalt vanust ning tagastab, kas tegemist on täisealise kasutajaga
        //1.Mida peaks meetod tagastama?
        //bool- true/false
        //2.Mis on meetodi nimi?
        //3.Kas meetod vajab sisendparametrid?
        //jah, kasutaja vanus

        static bool KasOnaisealine(int vanus)
        {
            return vanus > 17;
        }

    }
}
