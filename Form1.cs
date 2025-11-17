using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_Fadatok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Adatok(string orszag, string fovaros, string terulet, string nepesseg)
        {
            
            nevlabel.Text = orszag;
            fovaroslabel.Text = fovaros;
            teruletlabel.Text = terulet;
            nepesseglabel.Text = nepesseg;
        }

        private void nevlabel_Click(object sender, EventArgs e)
        {

        }

        private void fovaroslabel_Click(object sender, EventArgs e)
        {

        }

        private void teruletlabel_Click(object sender, EventArgs e)
        {

        }

        private void nepesseglabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Adatok("Ausztria", "Bécs", "83 871 km²", "9,158,750");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Adatok("Franciaország", "Párizs", "632 702 km²", "66 688 524");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Adatok("Nagy-Britannia", "London", "130 279 km²", "58 620 101");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Adatok("Magyarország", "Budapest", "93 026 km²", "9 603 634 ");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Adatok("USA", "Washington", "9 867 000 km²", "347 963 139");
        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
