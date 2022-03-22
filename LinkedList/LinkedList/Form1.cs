using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        Liste bagliListe = new Liste();

        private void button1_Click(object sender, EventArgs e)
        {
            bagliListe.sonaEkle(Convert.ToInt32(sayi.Text));
            listView.Items.Add(bagliListe.elemanlariYazdir());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bagliListe.basaEkle(Convert.ToInt32(sayi.Text));
            listView.Items.Add(bagliListe.elemanlariYazdir());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bagliListe.sondanSil();
            listView.Items.Add(bagliListe.elemanlariYazdir());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bagliListe.bastanSil();
            listView.Items.Add(bagliListe.elemanlariYazdir());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bagliListe.arayaEkle(Convert.ToInt32(indis.Text),Convert.ToInt32(sayi.Text));
            listView.Items.Add(bagliListe.elemanlariYazdir());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bagliListe.aradanSil(Convert.ToInt32(indis.Text));
            listView.Items.Add(bagliListe.elemanlariYazdir());
        }
    }
}
