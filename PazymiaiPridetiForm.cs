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
    public partial class PazymiaiPridetiForm : Form
    {
        public PazymiaiPridetiForm()
        {
            InitializeComponent();
        }

        PAZYMIAI pazymiai = new PAZYMIAI();
        KURSAS kursas = new KURSAS();
        STUDENT studentas = new STUDENT();

        private void PazymiaiPridetiForm_Load(object sender, EventArgs e)
        {
            comboBoxKursas.DataSource = kursas.gautiVisusKursus();
            comboBoxKursas.DisplayMember = "pavadinimas";
            comboBoxKursas.ValueMember = "id";

            SqlCommand query = new SqlCommand("SELECT id, vardas, pavarde FROM Studentai");
            dataGridView1.DataSource = studentas.getStudents(query);
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            textBoxStudentoID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
    }
}
