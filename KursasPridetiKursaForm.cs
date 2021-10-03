using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementBook
{
    public partial class KursasPridetiKursaForm : Form
    {
        public KursasPridetiKursaForm()
        {
            InitializeComponent();
        }

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
    }
}
