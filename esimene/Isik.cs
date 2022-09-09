using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    public abstract class Isik
    {
        public string nimi;
        public int sunniaasta;
        public enum sugu { mees, naine }
        public sugu InimSugu;
        public double sissetulek;
        public double maksuvaba;
        public double palk;
        public double tulumaks;


        public Isik(string nimi, int sunniaasta, sugu InimSugu, double maksuvaba, double palk)
        {
            this.nimi = nimi;
            this.sunniaasta = sunniaasta;
            this.InimSugu = InimSugu;
            this.maksuvaba = maksuvaba;
            this.palk = palk;
        }

        public abstract void printInfo();


        public abstract double arvSisse(double palk, double tulumaks, double maksuvaba);


        public int arvutaVanus()
        {
            int praeguneAasta = DateTime.Now.Year;
            int vanus = praeguneAasta - sunniaasta;
            return vanus;
        }

        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
    }
}
