using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP___Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ucitel ucitel;
        Zak zak;
        bool jeUcitel = false;
        short velikostTridy = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
                ucitel = new Ucitel(textBox1.Text, textBox2.Text, (short)numericUpDown1.Value);
            else
                ucitel = new Ucitel();
            jeUcitel = true;
            groupBox3.Enabled = true;
            label4.Text = "Neopravených testů: "+ucitel.neopraveneTesty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jeUcitel && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
                zak = new Zak(textBox4.Text, textBox3.Text, ucitel);
            else
                zak = new Zak();
            groupBox4.Enabled = true;
            label7.Text = "Naučenost: " + zak.naucenost;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucitel.OpravitTest();
            label4.Text = "Neopravených testů: " + ucitel.neopraveneTesty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucitel.napsatTestSeTridou(velikostTridy);
            label4.Text = "Neopravených testů: " + ucitel.neopraveneTesty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ucitel.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            zak.PsatTest();
            label4.Text = "Neopravených testů: " + ucitel.neopraveneTesty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zak.UcitSeNaTest();
            label7.Text = "Naučenost: " + zak.naucenost;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(zak.ToString());
        }
    }
}
