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
    public partial class Ocena : Form
    {
        public Ocena()
        {
            InitializeComponent();
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            Godina_Populate();
            Profesor_Populate();
        }

        DataTable ucenik, predmet, ocena, profesor, godina, odeljenje;
        private void Ucenik_Populate()
        {
            StringBuilder Builder = new StringBuilder("SELECT Osoba.id AS id, ime + ' ' + prezime AS naziv FROM Osoba");
            Builder.Append(" JOIN upisnica ON Osoba.id = Osoba WHERE upisnica.odeljenje_id = " + comboBoxOdeljenje.SelectedValue);

            SqlDataAdapter Adapt = new SqlDataAdapter(Builder.ToString(), konekcija.connect());
            ucenik = new DataTable();
            Adapt.Fill(ucenik);
            comboBoxUcenik.DataSource = ucenik;
            comboBoxUcenik.ValueMember = "id";
            comboBoxUcenik.DisplayMember = "naziv";
            comboBoxUcenik.SelectedIndex = -1;
        }

        private void Predmet_Populate()
        {
            StringBuilder Builder = new StringBuilder("SELECT DISTINCT predmet.id AS id, naziv FROM Predmet");
            Builder.Append(" JOIN raspodela ON predmet.id = predmet_id WHERE godina_id = " + comboBoxGodina.SelectedValue);
            Builder.Append(" AND nastavnik_id = " + comboBoxProfesor.SelectedValue);

            SqlDataAdapter Adapt = new SqlDataAdapter(Builder.ToString(), konekcija.connect());
            predmet = new DataTable();
            Adapt.Fill(predmet);
            comboBoxPredmet.DataSource = predmet;
            comboBoxPredmet.ValueMember = "id";
            comboBoxPredmet.DisplayMember = "naziv";
            comboBoxPredmet.SelectedIndex = -1;
        }

        private void Profesor_Populate()
        {
            StringBuilder Builder = new StringBuilder("SELECT DISTINCT Osoba.id AS id, ime + ' ' + prezime AS naziv FROM Osoba");
            Builder.Append(" JOIN Raspodela ON Osoba.id = nastavnik_id WHERE godina_id = " + comboBoxGodina.SelectedValue);

            SqlDataAdapter Adapt = new SqlDataAdapter(Builder.ToString(), konekcija.connect());
            profesor = new DataTable();
            Adapt.Fill(profesor);
            comboBoxProfesor.DataSource = profesor;
            comboBoxProfesor.ValueMember = "id";
            comboBoxProfesor.DisplayMember = "naziv";
            comboBoxProfesor.SelectedIndex = -1;
        }

        private void Godina_Populate()
        {
            SqlDataAdapter Adapt = new SqlDataAdapter("SELECT id, naziv FROM Skolska_godina", konekcija.connect());
            godina = new DataTable();
            Adapt.Fill(godina);
            comboBoxGodina.DataSource = godina;
            comboBoxGodina.ValueMember = "id";
            comboBoxGodina.DisplayMember = "naziv";
            if (comboBoxGodina != null) comboBoxGodina.SelectedIndex = comboBoxGodina.Items.Count - 1;
        }

        private void Odeljenje_Populate()
        {
            StringBuilder Builder = new StringBuilder("SELECT DISTINCT Odeljenje.id AS id, trim(str(razred)) + '-' + indeks AS naziv FROM Odeljenje");
            Builder.Append(" JOIN Raspodela ON Odeljenje.id = Odeljenje WHERE raspodela.godina_id = " + comboBoxGodina.SelectedValue);
            Builder.Append(" AND nastavnik_id = " + comboBoxProfesor.SelectedValue);
            Builder.Append(" AND predmet_id = " + comboBoxPredmet.SelectedValue);

            SqlDataAdapter Adapt = new SqlDataAdapter(Builder.ToString(), konekcija.connect());
            odeljenje = new DataTable();
            Adapt.Fill(odeljenje);
            comboBoxOdeljenje.DataSource = odeljenje;
            comboBoxOdeljenje.ValueMember = "id";
            comboBoxOdeljenje.DisplayMember = "naziv";
            comboBoxOdeljenje.SelectedIndex = -1;
        }

        private void Ocena_Populate()
        {
            StringBuilder Builder = new StringBuilder("SELECT ocena.id AS id, ime + ' ' + prezime AS naziv, ocena, ucenik_id, datum FROM Osoba");
            Builder.Append(" JOIN Ocena ON Osoba.id = ucenik_id");
            Builder.Append(" JOIN Raspodela ON raspodela.id = raspodela_id WHERE raspodela_id =");
            Builder.Append(" (SELECT id from raspodela WHERE godina_id = " + comboBoxGodina.SelectedValue);
            Builder.Append(" AND nastavnik_id = " + comboBoxProfesor.SelectedValue);
            Builder.Append(" AND Predmet_id = " + comboBoxPredmet.SelectedValue);
            Builder.Append(" AND Odeljenje = " + comboBoxOdeljenje.SelectedValue + ")");

            SqlDataAdapter Adapter = new SqlDataAdapter(Builder.ToString(), konekcija.connect());
            ocena = new DataTable();
            Adapter.Fill(ocena);
            dataGridViewOcena.DataSource = ocena;

            dataGridViewOcena.Columns["ucenik_id"].Visible = false;
            dataGridViewOcena.Columns["id"].Visible = false;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            StringBuilder Builder = new StringBuilder("SELECT id FROM Raspodela");
            Builder.Append(" WHERE godina_id = " + comboBoxGodina.SelectedValue);
            Builder.Append(" AND nastavnik_id = " + comboBoxProfesor.SelectedValue);
            Builder.Append(" AND predmet_id = " + comboBoxPredmet.SelectedValue);
            Builder.Append(" AND odeljenje_id = " + comboBoxOdeljenje.SelectedValue);

            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(Builder.ToString(), veza);
            int raspodela_id = 0;

            try
            {
                veza.Open();
                raspodela_id = (int)komanda.ExecuteScalar();
                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (raspodela_id == 0) return;

            komanda = new SqlCommand("INSERT INTO ocena VALUES ('" + dateTimePicker.Value.Date.ToString() + "', " + raspodela_id + ", " + numericUpDownOcena.Value + ", " + comboBoxUcenik.SelectedValue + ")", veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                Ocena_Populate();
                current_id = dataGridViewOcena.RowCount - 1;
                dataGridViewOcena.CurrentCell = dataGridViewOcena[current_cellC, current_id];
                buttonDelete.Enabled = buttonUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand("UPDATE ocena SET ucenik_id = " + comboBoxUcenik.SelectedValue + ", ocena = " + numericUpDownOcena.Value + ", datum = '" + dateTimePicker.Value.Date.ToString() + "' WHERE id = " + dataGridViewOcena.Rows[current_id].Cells["id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                Ocena_Populate();
                dataGridViewOcena.CurrentCell = dataGridViewOcena[current_cellC, current_id];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand("DELETE FROM ocena WHERE id = " + dataGridViewOcena.Rows[current_id].Cells["id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                Ocena_Populate();
                if (CheckDataGrid())
                {
                    if (current_id > 0) dataGridViewOcena.CurrentCell = dataGridViewOcena[current_cellC, --current_id];
                    else dataGridViewOcena.CurrentCell = dataGridViewOcena[current_cellC, current_id];
                    SelectedRowChanged(current_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckDataGrid()
        {
            if (dataGridViewOcena.RowCount == 0)
            {
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
                return false;
            }
            else
            {
                buttonDelete.Enabled = true;
                buttonUpdate.Enabled = true;
                SelectedRowChanged(0);
                return true;
            }
        }

        private void cbGodina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxGodina.IsHandleCreated && comboBoxGodina.Focused) Profesor_Populate();
        }

        private void cbProfesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxProfesor.IsHandleCreated && comboBoxProfesor.Focused)
            {
                Predmet_Populate();
                comboBoxPredmet.Enabled = true;
            }
        }

        private void cbPredmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxPredmet.IsHandleCreated && comboBoxPredmet.Focused)
            {
                Odeljenje_Populate();
                comboBoxOdeljenje.Enabled = true;
            }
        }

        private void cbOdeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxOdeljenje.IsHandleCreated && comboBoxOdeljenje.Focused)
            {
                Ucenik_Populate();
                Ocena_Populate();
                if (CheckDataGrid() || comboBoxUcenik.Items.Count > 0)
                {
                    comboBoxUcenik.Enabled = numericUpDownOcena.Enabled = dateTimePicker.Enabled = true;
                    buttonInsert.Enabled = true;
                    current_id = 0;
                    current_cellC = 1;
                }
            }
        }

        private void cbProfesor_TextChanged(object sender, EventArgs e)
        {
            comboBoxPredmet.SelectedIndex = -1;
            comboBoxPredmet.Enabled = false;
        }

        private void cbPredmet_TextChanged(object sender, EventArgs e)
        {
            comboBoxOdeljenje.SelectedIndex = -1;
            comboBoxOdeljenje.Enabled = false;
        }

        private void cbOdeljenje_TextChanged(object sender, EventArgs e)
        {
            comboBoxUcenik.SelectedIndex = -1;
            comboBoxUcenik.Enabled = numericUpDownOcena.Enabled = dateTimePicker.Enabled = false;
            buttonInsert.Enabled = buttonDelete.Enabled = buttonUpdate.Enabled = false;
            dataGridViewOcena.DataSource = null;
            numericUpDownOcena.Value = 5;
            dateTimePicker.Value = DateTime.Now;
        }

        private void SelectedRowChanged(int n)
        {
            comboBoxUcenik.SelectedValue = (int)dataGridViewOcena.Rows[n].Cells["ucenik_id"].Value;
            numericUpDownOcena.Value = (int)dataGridViewOcena.Rows[n].Cells["ocena"].Value;
            dateTimePicker.Value = (DateTime)dataGridViewOcena.Rows[n].Cells["datum"].Value;
        }

        int current_id = 0;
        int current_cellC = 1;
        private void dgOcena_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dataGridViewOcena.Focused || dataGridViewOcena.CurrentRow == null) return;
            current_id = dataGridViewOcena.CurrentRow.Index;
            current_cellC = dataGridViewOcena.CurrentCell.ColumnIndex;
            SelectedRowChanged(current_id);
        }
    }
}
