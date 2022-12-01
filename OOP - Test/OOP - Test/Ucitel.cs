using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Test
{
    class Ucitel
    {
        private string jmeno;
        private string prijmeni;
        public short neopraveneTesty;

        public string Jmeno { get=>jmeno; }
        public string Prijmeni { get => prijmeni; }

        public Ucitel()
        {
            jmeno = "John";
            prijmeni = "Gray";
            neopraveneTesty = 5;
        }
        public Ucitel(string jmeno,string prijmeni, short neopraveneTesty)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.neopraveneTesty = neopraveneTesty;
        }

        public void OpravitTest()
        {
            if (neopraveneTesty > 0)
                neopraveneTesty--;
            else
                MessageBox.Show("Není co opravovat!!");
        }

        public void napsatTestSeTridou(short pocetZaku)
        {
            if (pocetZaku > 0)
                neopraveneTesty += pocetZaku;
        }

        public override string ToString()
        {
            return "Učitel "+Jmeno+" "+Prijmeni+" má "+neopraveneTesty+" neopravených testů";
        }
    }
}
