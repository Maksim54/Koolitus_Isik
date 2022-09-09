//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Kordamine
//{
//    class koer : Koduloom
//    {
//        //public string toug; //tõug - порода
//        public enum toug { labrador, haski, pudel, buldog };
//        public toug Toug;
//        public koer(toug Toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
//        {
//            this.Toug = Toug;
//        }
//        public koer(koer koer) //kloonimiseks
//        {
//            this.Toug = koer.Toug;
//            this.nimi = koer.nimi;
//            this.varv = koer.varv;
//            this.loomaSugu = koer.loomaSugu;
//            this.kaal = koer.kaal;
//            this.vanus = koer.vanus;
//            this.elav = koer.elav;
//        }

//        public override void print_golos()
//        {
//            Console.WriteLine("Gav gav");
//        }

//        public override void print_Info()
//        {
//            Console.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana", Toug, varv, nimi, loomaSugu, kaal, vanus);
//        }
//        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
//    }
//}
