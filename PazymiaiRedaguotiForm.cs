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

namespace ManagementBook
{
    public partial class PazymiaiRedaguotiForm : Form
    {
        public PazymiaiRedaguotiForm()
        {
            InitializeComponent();
        }

        PAZYMIAI pazymiai = new PAZYMIAI();
        STUDENT student = new STUDENT();
        KURSAS kursas = new KURSAS();
        string data = "pazimys";

        private void PazymiaiRedaguotiForm_Load(object sender, EventArgs e)
        {
            comboBoxKursas.DataSource = kursas.gautiVisusKursus();
            comboBoxKursas.DisplayMember = "pavadinimas";
            comboBoxKursas.ValueMember = "id";

            dataGridView1.DataSource = pazymiai.getStudentsScore();
        }

        private void ButtonRodytiStudentus_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("SELECT id, vardas, pavarde, gimtadienis FROM Studentai");
            dataGridView1.DataSource = student.getStudents(query);
        }

        private void ButtonRodytiPazymius_Click(object sender, EventArgs e)
        {
            data = "pazimys";
            dataGridView1.DataSource = pazymiai.getStudentsScore();
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            getDataFromDataGridView();
        }

        public void getDataFromDataGridView()
        {
            if(data == "studentas")
            {
                textBoxStudentoID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else if(data == "pazimys")
            {
                textBoxStudentoID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBoxKursas.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            }

        }

        private void ButtonPridetiPazymi_Click(object sender, EventArgs e)
        {
            try
            {
                int studentoId = Convert.ToInt32(textBoxStudentoID.Text);
                int kursoid = Convert.ToInt32(comboBoxKursas.SelectedValue);
                int pazymioSkc = Convert.ToInt32(textBoxPazimys.Text);
                string aprasymas = textBoxAprasymas.Text;

                if (!pazymiai.studentScoreExists(studentoId, kursoid))
                {
                    if (pazymiai.pridetiPazymi(studentoId, kursoid, pazymioSkc, aprasymas))
                    {
                        MessageBox.Show("Pažimys pridėtas sėkmingas", "Pridėti pažimį", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pažimio pridėti nepavyko", "Pridėti pažimį", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Pažymys šiam kursui jau yra pridėtas ", "Pridėti pažimį", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pridėti pažimį", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRemovePazymi_Click(object sender, EventArgs e)
        {
            int studentoId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int kursoid = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            if (MessageBox.Show("Ar tikrai norite ištrinti pažimį?", "Ištrinti pažimį", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pazymiai.deletePazimys(studentoId, kursoid))
                {
                    MessageBox.Show("Pažimys ištrintas", "Ištrinti pažimį", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = pazymiai.getStudentsScore();
                }
                else
                {
                    MessageBox.Show("Ištrinti pažymio nepavyko", "Ištrinti pažimį", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ButtonPazVidurkis_Click(object sender, EventArgs e)
        {
            PazymiaiVidurkis vidurkis = new PazymiaiVidurkis();
            vidurkis.Show(this);
        }

        private void ComboBoxKursas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
