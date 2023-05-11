using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnik
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {

        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba nova = new Osoba();
            nova.Show();
        }

        private void odeljenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odeljenje nova = new Odeljenje();
            nova.Show();
        }

        private void smerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik nova = new Sifarnik("smer");
            nova.Show();
        }

        private void školskaGodinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik nova = new Sifarnik("skolska_godina");
            nova.Show();
        }

        private void oCeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocena nova = new Ocena();
            nova.Show();
        }
    }
}
