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
using System.IO;

namespace ManagementBook
{
    public partial class addStudent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\X\Documents\DB.mdf;Integrated Security = True; Connect Timeout = 30");

        public addStudent()
        {
            InitializeComponent();
        }

        private void ButtonIssaugotiStudent_Click(object sender, EventArgs e)
        {

            // prideti nauja studenta

            STUDENT student = new STUDENT();

            string vardas = textBoxVardas.Text;
            string pavarde = textBoxPavarde.Text;
            DateTime gimtadienis = dateTimePicker1.Value;
            string telefonas = textBoxTelefonas.Text;
            string adresas = textBoxAdresas.Text;
            string lytis = "Vyras";

            if (radioButtonMoteris.Checked)
            {
                lytis = "Moteris";
            }

            MemoryStream nuotrauka = new MemoryStream();

            int gimimo_metai = dateTimePicker1.Value.Year;
            int dabartiniai_metai = DateTime.Now.Year;

             if(((dabartiniai_metai - gimimo_metai) < 10) || ((dabartiniai_metai - gimimo_metai) > 100))
            {
                MessageBox.Show("Studento amžius negali būti mažesnis už 10 bei didesnis už 100", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (verif())
            {
                pictureBoxStudentoImg.Image.Save(nuotrauka, pictureBoxStudentoImg.Image.RawFormat);

                if (student.insertStudent(vardas, pavarde, gimtadienis, telefonas, lytis, adresas, nuotrauka))
                {
                    MessageBox.Show("Naujas studentas pridėtas", "Pridėti studentą", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Pridėti studentą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tuščias laukelis", "Pridėti studentą", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        bool verif()
        {
            if((textBoxVardas.Text.Trim() == "") ||
                (textBoxPavarde.Text.Trim() == "") ||
                (textBoxTelefonas.Text.Trim() == "") ||
                (textBoxAdresas.Text.Trim() == "") ||
                (pictureBoxStudentoImg.Image == null ))

            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pasirinkite nuotrauka(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentoImg.Image = Image.FromFile(opf.FileName);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
