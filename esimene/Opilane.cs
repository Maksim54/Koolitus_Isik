using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Opilane : Isik
    {

        public string koolinimi;
        public int klass;
        public string spetsialiseerimine;

        public Opilane(string koolinimi, int klass, string spetsialiseerumine, string nimi, int sunniaasta, sugu isikSugu, double maksuvaba, double palk) : base(nimi, sunniaasta, isikSugu, maksuvaba, palk)

        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerimine = spetsialiseerimine;
        }

        //public override int arvutaVanus()
        //{
        //    int praeguneAasta = DateTime.Now.Year;
        //    int vanus = praeguneAasta - sunniaasta;
        //    return vanus;
        //}




        public override double arvSisse(double maksuvaba, double tulumaks, double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }

        public override void printInfo()
        {
            Console.WriteLine($"Tema koolinimi on {koolinimi} ja ta õpib klassis #{klass}, ja tema spetsialiseerimine on {spetsialiseerimine}, tema töötasu on {arvSisse(palk, maksuvaba, tulumaks)},tema nimi on {nimi}, ta on {InimSugu} ja tema vanus on {base.arvutaVanus()}");
        }
    }
}
