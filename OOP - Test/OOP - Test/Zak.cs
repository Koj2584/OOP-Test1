using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Test
{
    class Zak
    {
        private string jmeno;
        private string prijmeni;
        public Ucitel ucitel;
        public short naucenost;

        public string Jmeno { get => jmeno; }
        public string Prijmeni { get => prijmeni; }

        public Zak()
        {
            jmeno = "Deny";
            prijmeni = "Lee";
            ucitel = new Ucitel();
            naucenost = 0;
        }
        public Zak(string jmeno, string prijmeni, Ucitel ucitel)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.ucitel = ucitel;
            naucenost = 0;
        }

        public void PsatTest()
        {
            ucitel.neopraveneTesty++;
        }

        public void UcitSeNaTest()
        {
            naucenost += (short)new Random().Next(1, 20);
            if (naucenost > 100)
                naucenost = 100;
        }

        public override string ToString()
        {
            return "Žák "+Jmeno+" "+Prijmeni+" ma za učitele "+ucitel.Jmeno+" "+ucitel.Prijmeni+" a je na "+naucenost+"% naučený na test";
        }
    }
}
