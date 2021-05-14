using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szamologep.Lib;

namespace Szamologep
{
    public partial class Kalkulator : Form
    {
        private readonly Gep _gep = new Gep();
        public Kalkulator()
        {
            InitializeComponent();
            kiir();
        }
        private void kiir()
        {
            txtErtek.Text = _gep.Ertek;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            _gep.Be(Szamjegyek.Szj_0);
            kiir();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            _gep.Be(Szamjegyek.Szj_1);
            kiir();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            _gep.Be(Szamjegyek.Szj_2);
            kiir();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            _gep.Be(Szamjegyek.Szj_3);
            kiir();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            _gep.Be(Szamjegyek.Szj_4);
            kiir();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            _gep.Be(Szamjegyek.Szj_5);
            kiir();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            _gep.Be(Szamjegyek.Szj_6);
            kiir();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            _gep.Be(Szamjegyek.Szj_7);
            kiir();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            _gep.Be(Szamjegyek.Szj_8);
            kiir();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            _gep.Be(Szamjegyek.Szj_9);
            kiir();
        }

        private void bEgyPerX_Click(object sender, EventArgs e)
        {
            _gep.Be(Unaris.EgyPerX);
            kiir();
        }

        private void bXNegyzet_Click(object sender, EventArgs e)
        {
            _gep.Be(Unaris.XNegyzet);
            kiir();
        }

        private void bGyokX_Click(object sender, EventArgs e)
        {
            _gep.Be(Unaris.GyokX);
            kiir();
        }

        private void bNegacio_Click(object sender, EventArgs e)
        {
            _gep.Be(Unaris.Negacio);
            kiir();
        }

        private void bVissza_Click(object sender, EventArgs e)
        {
            _gep.Vissza();
            kiir();
        }

        private void bTizedes_Click(object sender, EventArgs e)
        {
            _gep.Tizedes();
            kiir();
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            _gep.CE();
            kiir();
        }
    }
}
