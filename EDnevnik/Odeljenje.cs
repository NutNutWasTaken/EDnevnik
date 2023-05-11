using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace eDnevnik
{
    public partial class Odeljenje : Form
    {
        int broj_sloga = 0;
        DataTable tabelaOdeljenje;

        public Odeljenje()
        {
            InitializeComponent();
        }

        private void Odeljenje_Load(object sender, EventArgs e)
        {
            SqlConnection veza = konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM smer", veza);
            DataTable tabelaSmer = new DataTable();
            adapter.Fill(tabelaSmer);
            comboBoxSmer.DataSource = tabelaSmer;
            comboBoxSmer.ValueMember = "id";
            comboBoxSmer.DisplayMember = "Naziv";
            adapter = new SqlDataAdapter("SELECT * FROM odeljenje", veza);
            tabelaOdeljenje = new DataTable();
            adapter.Fill(tabelaOdeljenje);
            textBoxID.Text = tabelaOdeljenje.Rows[broj_sloga][0].ToString();
            textBoxRazred.Text = tabelaOdeljenje.Rows[broj_sloga][1].ToString();
            textBoxIndeks.Text = tabelaOdeljenje.Rows[broj_sloga][2].ToString();
            comboBoxSmer.SelectedValue = (int)tabelaOdeljenje.Rows[broj_sloga][3];
            adapter = new SqlDataAdapter("SELECT id, ime+' '+prezime AS imeprezime FROM osoba WHERE uloga=2", veza);
            DataTable tabelaOsoba = new DataTable();
            adapter.Fill(tabelaOsoba);
            comboBoxRazredni.DataSource = tabelaOsoba;
            comboBoxRazredni.DisplayMember = "imeprezime";
            comboBoxRazredni.ValueMember = "id";
            comboBoxRazredni.SelectedValue = (int)tabelaOdeljenje.Rows[broj_sloga][4];
            adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable tabelaGodina = new DataTable();
            adapter.Fill(tabelaGodina);
            comboBoxGodina.DataSource = tabelaGodina;
            comboBoxGodina.DisplayMember = "naziv";
            comboBoxGodina.ValueMember = "id";
            comboBoxGodina.SelectedValue = (int)tabelaOdeljenje.Rows[broj_sloga][5];
        }

        //Prikaz podataka iz tabele
        private void Populate(int broj_sloga)
        {
            if (tabelaOdeljenje.Rows.Count == 0)
            {
                textBoxID.Text = "";
                textBoxRazred.Text = "";
                textBoxIndeks.Text = "";
                comboBoxSmer.SelectedIndex = -1;
                comboBoxGodina.SelectedIndex = -1;
                comboBoxRazredni.SelectedIndex = -1;
            }
            else
            {
                textBoxID.Text = tabelaOdeljenje.Rows[broj_sloga][0].ToString();
                textBoxRazred.Text = tabelaOdeljenje.Rows[broj_sloga][1].ToString();
                textBoxIndeks.Text = tabelaOdeljenje.Rows[broj_sloga][2].ToString();
                comboBoxRazredni.SelectedValue = (int)tabelaOdeljenje.Rows[broj_sloga][4];
                comboBoxSmer.SelectedValue = (int)tabelaOdeljenje.Rows[broj_sloga][3];
                comboBoxGodina.SelectedValue = (int)tabelaOdeljenje.Rows[broj_sloga][5];
                if (broj_sloga == tabelaOdeljenje.Rows.Count - 1)
                {
                    buttonForward.Enabled = false;
                    buttonEnd.Enabled = false;
                }
                else
                {
                    buttonForward.Enabled = true;
                    buttonEnd.Enabled = true;
                }
                if (broj_sloga == 0)
                {
                    buttonBackward.Enabled = false;
                    buttonBegin.Enabled = false;
                }
                else
                {
                    buttonBackward.Enabled = true;
                    buttonBegin.Enabled = true;
                }

            }
        }

        //Dugmici za navigaciju po tabeli
        private void buttonBegin_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Populate(broj_sloga);
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Populate(broj_sloga);
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Populate(broj_sloga);
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            broj_sloga = tabelaOdeljenje.Rows.Count - 1;
            Populate(broj_sloga);
        }

        // ZA INSERT I DELETE: comboBoxSmer.SelectedItem.ToString() daje System.Data.DataRowView
        // i za tabelaSmerP.Rows[0][0] kaze da nema reda na toj poziciji
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string naredba = "INSERT INTO odeljenje VALUES('";
            naredba = naredba + "razred = '" + textBoxRazred.Text + "',";
            naredba = naredba + "indeks = '" + textBoxIndeks.Text + "',";
            SqlConnection vezaP = konekcija.connect();
            SqlDataAdapter adapterP = new SqlDataAdapter("SELECT * FROM smer WHERE naziv='"+ comboBoxSmer.SelectedItem.ToString() +"'", vezaP);
            DataTable tabelaSmerP = new DataTable();
            adapterP.Fill(tabelaSmerP);
            naredba = naredba + "smer_id = " + tabelaSmerP.Rows[0][0] + ","; 
            SqlConnection vezaP2 = konekcija.connect();
            SqlDataAdapter adapterP2 = new SqlDataAdapter("SELECT * FROM osoba WHERE ime+' '+prezime='" + comboBoxRazredni.SelectedItem.ToString() + "'", vezaP2);
            DataTable tabelaRazredniP = new DataTable();
            adapterP2.Fill(tabelaRazredniP);
            naredba = naredba + "razredni_id = " + tabelaRazredniP.Rows[0][0] + ",";
            SqlConnection vezaP3 = konekcija.connect();
            SqlDataAdapter adapterP3 = new SqlDataAdapter("SELECT * FROM skolska_godina WHERE naziv='" + comboBoxGodina.SelectedItem.ToString() + "'", vezaP3);
            DataTable tabelaGodinaP = new DataTable();
            adapterP3.Fill(tabelaGodinaP);
            naredba = naredba + "godina_id = " + tabelaGodinaP.Rows[0][0] + ")";
            textBoxCommand.Text = naredba;
            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska) { MessageBox.Show(greska.GetType().ToString(), "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM odeljenje", veza);
            tabelaOdeljenje = new DataTable();
            adapter.Fill(tabelaOdeljenje);
            Populate(broj_sloga);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE odeljenje SET ";
            naredba = naredba + "razred = '" + textBoxRazred.Text + "',";
            naredba = naredba + "indeks = '" + textBoxIndeks.Text + "',";
            SqlConnection vezaP = konekcija.connect();
            SqlDataAdapter adapterP = new SqlDataAdapter("SELECT * FROM smer WHERE naziv='" + comboBoxSmer.SelectedItem.ToString() + "'", vezaP);
            DataTable tabelaSmerP = new DataTable();
            adapterP.Fill(tabelaSmerP);
            naredba = naredba + "smer_id = " + tabelaSmerP.Rows[0][0] + ",";
            SqlConnection vezaP2 = konekcija.connect();
            SqlDataAdapter adapterP2 = new SqlDataAdapter("SELECT * FROM osoba WHERE ime+' '+prezime='" + comboBoxRazredni.SelectedItem.ToString() + "'", vezaP2);
            DataTable tabelaRazredniP = new DataTable();
            adapterP2.Fill(tabelaRazredniP);
            naredba = naredba + "razredni_id = " + tabelaRazredniP.Rows[0][0] + ",";
            SqlConnection vezaP3 = konekcija.connect();
            SqlDataAdapter adapterP3 = new SqlDataAdapter("SELECT * FROM skolska_godina WHERE naziv='" + comboBoxGodina.SelectedItem.ToString() + "'", vezaP3);
            DataTable tabelaGodinaP = new DataTable();
            adapterP3.Fill(tabelaGodinaP);
            naredba = naredba + "godina_id = " + tabelaGodinaP.Rows[0][0] + " ";
            naredba = naredba + "WHERE id=" + textBoxID.Text;
            textBoxCommand.Text = naredba;
            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska) { MessageBox.Show(greska.GetType().ToString(), "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM odeljenje", veza);
            tabelaOdeljenje = new DataTable();
            adapter.Fill(tabelaOdeljenje);
            Populate(broj_sloga);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM odeljenje WHERE id=" + textBoxID.Text;
            textBoxCommand.Text = naredba;
            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            if (broj_sloga == tabelaOdeljenje.Rows.Count - 1) broj_sloga--;
            if (broj_sloga < 0) broj_sloga = 0;
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM odeljenje", veza);
            tabelaOdeljenje = new DataTable();
            adapter.Fill(tabelaOdeljenje);
            Populate(broj_sloga);
        }

        //Pretraga odeljenja
        string p, q, s;
        public void Search(string p, string q)
        {
            int n = 0;
            int i = 0;
            for (i = 0; i < tabelaOdeljenje.Rows.Count; i++)
            {
                if (p == tabelaOdeljenje.Rows[i][1].ToString() && q == tabelaOdeljenje.Rows[i][2].ToString())
                {
                    broj_sloga = i;
                    Populate(broj_sloga);
                }
                else
                {
                    n++;
                }
            }
            if (n == i) MessageBox.Show("Ovo odeljenje ne postoji u bazi!", "Pretraga", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
        } //pretraga odeljenja po 'nazivu'
        public void SearchID(string s) //pretraga odeljenja po ID-u
        {
            int n = 0;
            int i = 0;
            for (i = 0; i < tabelaOdeljenje.Rows.Count; i++)
            {
                if (s == tabelaOdeljenje.Rows[i][0].ToString())
                {
                    broj_sloga = i;
                    Populate(broj_sloga);
                }
                else
                {
                    n++;
                }
            }
            if (n == i) MessageBox.Show("Ovo odeljenje ne postoji u bazi!", "Pretraga", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            p = textBoxSR.Text;
            q = textBoxSI.Text;
            s = textBoxSearchID.Text;
            if (p == "" && q == "" && textBoxSearchID.Text == "")
            {
                MessageBox.Show("Morate uneti tekst u pretragu!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (p != "" && q != "" && textBoxSearchID.Text == "")
            {
                Search(p, q);
            }
            else if (p == "" && q == "" && textBoxSearchID.Text != "")
            {
                SearchID(s);
            }
            else
            {
                MessageBox.Show("Neispravno ste uneli parametre pretrage!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Pomoc
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Pretraga se vrši klikom na lupu.", "Pomoć", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
