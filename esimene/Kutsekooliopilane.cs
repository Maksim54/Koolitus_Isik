using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Kutsekooliopilane : Isik
    {
        public string oppeasutus;
        public string eriala;

        public int kursus;
        public int toetus;


        public string elukoht;
        public double keskhinne;
        public int lapsed;
        public double vanemad_palk;

        double Soidutoetus = 0;
        double Pohitoetus = 0;
        double Eritoetus = 0;
        double tulemus;

        public Kutsekooliopilane(string oppeasutus,string elukoht, double vanemad_palk, int lapsed,double keskhinne, string eriala, int kursus, int toetus, string klass, string spetsialiseerumine, string nimi, int sunniaasta, sugu InimSugu, double maksuvaba, double palk) : base(nimi, sunniaasta, InimSugu, maksuvaba, palk)
        {

            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
        }


        //public override int arvutaVanus()
        //{
        //    int praeguneAasta = DateTime.Now.Year;
        //    int vanus = praeguneAasta - sunniaasta;
        //    return vanus;
        //}

        public string Toetus()
        {
            if (elukoht != "Tallinn")
            {
                Soidutoetus = 50;
            }
            if (keskhinne >= 3.4)
            {
                Pohitoetus = 60;
            }
            if (lapsed > 2 || vanemad_palk <= 500)
            {
                Eritoetus = 90;
            }
            string toetus = $"sõidetoetus {Soidutoetus}, eritoetus {Eritoetus}, põhitoetus {Pohitoetus}";
            return toetus;
        }

        public double arvToetus()
        {
            tulemus = Pohitoetus + Eritoetus + Soidutoetus;
            return tulemus;
        }

        public override double arvSisse(double maksuvaba, double tulumaks, double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }
        public override void printInfo()
        {

            Console.WriteLine($"Tema õppeasutus on {oppeasutus} ja tema eriala on {eriala}, ta on kursusel #{kursus} ja tema toetus on {Toetus()}, tema töötasu on {arvSisse(palk, maksuvaba, tulumaks)}, tema nimi on {nimi}, ta on {InimSugu} ja tema vanus on {base.arvutaVanus()}");
        }

    }
}
