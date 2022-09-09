using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Tootaja : Isik
    {

        public string asutus;
        public string amet;

        public Tootaja(string asutus, string amet, int tootasu, string nimi, int sunniaasta, sugu InimSugu, double maksuvaba, double palk): base(nimi, sunniaasta, InimSugu, maksuvaba, palk)
        {
            this.asutus = asutus;
            this.amet = amet;
        }

        public override double arvSisse(double maksuvaba, double tulumaks, double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }

        //public override int arvutaVanus()
        //{
        //    int praeguneAasta = DateTime.Now.Year;
        //    int vanus = praeguneAasta - sunniaasta;
        //    return vanus;
        //}


        public override void printInfo()
        {
            Console.WriteLine($"Tema asutus on {asutus}, ta töötab {amet}, tema töötasu on {arvSisse(palk, maksuvaba, tulumaks)}, tema nimi on {nimi}, ta on {InimSugu} ja tema vanus on {base.arvutaVanus()} "); 
        }
    }
}
