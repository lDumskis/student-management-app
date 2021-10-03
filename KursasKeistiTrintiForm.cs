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
    public partial class KursasKeistiTrintiForm : Form
    {
        public KursasKeistiTrintiForm()
        {
            InitializeComponent();
        }

        KURSAS kursas = new KURSAS();
        int pos;

        private void KursasKeistiTrintiForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }

        // funkcija uzpildyti duomenimis listbox

        public void reloadListBoxData()
        {
            listBoxKursai.DataSource = kursas.gautiVisusKursus();
            listBoxKursai.ValueMember = "id";
            listBoxKursai.DisplayMember = "pavadinimas";

            listBoxKursai.SelectedItem = null;

            labelVisoKursu.Text = "Viso kursų: " + kursas.visiKursai();
        }

        void showData(int index)
        {

            DataRow dr = kursas.gautiVisusKursus().Rows[index];
            listBoxKursai.SelectedIndex = index;
            textBoxID.Text = dr.ItemArray[0].ToString();
            textBoxPavadinimas.Text = dr.ItemArray[1].ToString();
            numericUpDownValandos.Value = Int32.Parse(dr.ItemArray[2].ToString());
            textBoxAprasymas.Text = dr.ItemArray[3].ToString();

        }



        private void ListBoxKursai_Click(object sender, EventArgs e)
        {
            pos = listBoxKursai.SelectedIndex;
            showData(pos);
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(0);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (pos < (kursas.gautiVisusKursus().Rows.Count - 1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            pos = kursas.gautiVisusKursus().Rows.Count - 1;
            showData(pos);
        }

        // mygtukas prideti kursui
        private void ButtonPridetiKursa_Click(object sender, EventArgs e)
        {
            string pavadinimas = textBoxPavadinimas.Text;
            int valandos = (int)numericUpDownValandos.Value;
            string aprasymas = textBoxAprasymas.Text;

            KURSAS kursas = new KURSAS();

            if(pavadinimas.Trim() == "")
            {
                MessageBox.Show("Pridėkite kurso pavadinimą", "Prideti kursa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kursas.tikrintiKursoPav(pavadinimas))
            {
                if (kursas.insertCourse(pavadinimas, valandos, aprasymas))
                {
                    MessageBox.Show("Naujas kursas pridetas", "Prideti kursa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                    textBoxID.Text = "";
                    numericUpDownValandos.Value = 10;
                    textBoxPavadinimas.Text = "";
                    textBoxAprasymas.Text = "";
                }
                else
                {
                    MessageBox.Show("Naujas kursas nepridėtas", "Prideti kursa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kursas tokiu pavadinimu jau egzsituoja", "Prideti kursa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // mygtukas redaguoti kursui
        private void ButtonAtnaujintiKursa_Click(object sender, EventArgs e)
        {
           
                string kursoPav = textBoxPavadinimas.Text;
                int val = (int)numericUpDownValandos.Value;
                string apra = textBoxAprasymas.Text;
                int id = Convert.ToInt32(textBoxID.Text);

                if (kursoPav.Trim() != "")
                {
                    if (!kursas.tikrintiKursoPav(kursoPav, id))
                    {
                        MessageBox.Show("Kursas tokiu pavadinimu jau egzsituoja", "Redaguoti kursa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (kursas.redaguotiKursa(id, kursoPav, val, apra))
                    {
                        MessageBox.Show("Kursas atnaujintas", "Redaguoti kursą", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                        textBoxID.Text = "";
                        numericUpDownValandos.Value = 10;
                        textBoxPavadinimas.Text = "";
                        textBoxAprasymas.Text = "";
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

        // mygtukas istrinti kursui
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);

            KURSAS kursas = new KURSAS();

            if (MessageBox.Show("Ar tikrai norite ištrinti kursą?", "Ištrinti kursą", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (kursas.deleteKursas(id))
                {
                    MessageBox.Show("Kursas ištrintas", "Ištrinti kursą", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                    textBoxID.Text = "";
                    numericUpDownValandos.Value = 10;
                    textBoxPavadinimas.Text = "";
                    textBoxAprasymas.Text = "";
                }
                else
                {
                    MessageBox.Show("Ištrinti kurso nepavyko", "Ištrinti kursą", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ButtonIsvalyti_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            numericUpDownValandos.Value = 10;
            textBoxPavadinimas.Text = "";
            textBoxAprasymas.Text = "";
        }
    }
}
