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
    public partial class RedaguotiForm : Form

    {
        MY_DB mydb = new MY_DB();
        public RedaguotiForm()
        {
            InitializeComponent();
        }

        KURSAS kursas = new KURSAS();

        private void RedaguotiForm_Load_1(object sender, EventArgs e)
        {
            comboBoxKursas.DataSource = kursas.gautiVisusKursus();
            comboBoxKursas.DisplayMember = "pavadinimas";
            comboBoxKursas.ValueMember = "id";

            comboBoxKursas.SelectedItem = null;
        }

        public void fillcombo()
        {
            comboBoxKursas.DataSource = kursas.gautiVisusKursus();
            comboBoxKursas.DisplayMember = "pavadinimas";
            comboBoxKursas.ValueMember = "id";

        }

        private void ButtonAtnaujintiKursa_Click(object sender, EventArgs e)
        {
                    string kursoPav = textBoxPavadinimas.Text;
                    int val = (int)numericUpDownValandos.Value;
                    string apra = textBoxAprasymas.Text;
                    int id = (int)comboBoxKursas.SelectedValue;

                if(kursoPav.Trim() != "")
                {
                    if (!kursas.tikrintiKursoPav(kursoPav, id))
                    {
                        MessageBox.Show("Kursas tokiu pavadinimu jau egzsituoja", "Redaguoti kursa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (kursas.redaguotiKursa(id, kursoPav, val, apra))
                    {
                        MessageBox.Show("Kursas atnaujintas", "Redaguoti kursą", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillcombo();
                    }
                    else
                    {
                        MessageBox.Show("Kurso atnaujinti nepavyko", "Redaguoti kursa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Iveskite kurso pavadinima", "Redaguoti kursa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        private void ComboBoxKursas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxKursas.SelectedValue);
                DataTable table = new DataTable();
                table = kursas.gautiKursusId(id);
                textBoxPavadinimas.Text = table.Rows[0][1].ToString();
                numericUpDownValandos.Value = Int32.Parse(table.Rows[0][2].ToString());
                textBoxAprasymas.Text = table.Rows[0][3].ToString();
            }
            catch { }
        }

    }
}
