using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ManagementBook
{
    public partial class StudentaiEditRemoveForm : Form
    {
        public StudentaiEditRemoveForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pasirinkite nuotrauka(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentoImg.Image = Image.FromFile(opf.FileName);
            }
        }

        bool verif()
        {
            if ((textBoxVardas.Text.Trim() == "") ||
                (textBoxPavarde.Text.Trim() == "") ||
                (textBoxTelefonas.Text.Trim() == "") ||
                (textBoxAdresas.Text.Trim() == "") ||
                (pictureBoxStudentoImg.Image == null))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
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

            if (((dabartiniai_metai - gimimo_metai) < 10) || ((dabartiniai_metai - gimimo_metai) > 100))
            {
                MessageBox.Show("Studento amžius negali būti mažesnis už 10 bei didesnis už 100", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (verif())
            {
                pictureBoxStudentoImg.Image.Save(nuotrauka, pictureBoxStudentoImg.Image.RawFormat);

                if (student.updateStudent(id, vardas, pavarde, gimtadienis, telefonas, lytis, adresas, nuotrauka))
                {
                    MessageBox.Show("Klaida", "Pridėti studentą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Studento informacija atnaujinta", "Pridėti studentą", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tuščias laukelis", "Pridėti studentą", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            // istrinti pasirinkta studenta
            int id = Convert.ToInt32(textBoxID.Text);

            if (MessageBox.Show("Ar tikrai norite ištrinti studentą?","Ištrinti studentą",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (student.deleteStudent(id))
                {
                    MessageBox.Show("Studentas ištrintas", "Ištrinti studentą", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxID.Text = "";
                    textBoxVardas.Text = "";
                    textBoxPavarde.Text = "";
                    textBoxTelefonas.Text = "";
                    textBoxAdresas.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    pictureBoxStudentoImg.Image = null;
                }
                else
                {
                    MessageBox.Show("Studentas neištrintas", "Ištrinti studentą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            SqlCommand query = new SqlCommand("SELECT id, vardas, pavarde, gimtadienis, lytis, telefonas, adresas, nuotrauka FROM Studentai WHERE id ="+id);

            DataTable table = student.getStudents(query);

            if(table.Rows.Count > 0)
            {
                textBoxVardas.Text = table.Rows[0]["vardas"].ToString();
                textBoxPavarde.Text = table.Rows[0]["pavarde"].ToString();
                textBoxTelefonas.Text = table.Rows[0]["telefonas"].ToString();
                textBoxAdresas.Text = table.Rows[0]["adresas"].ToString();

                dateTimePicker1.Value = (DateTime)table.Rows[0]["gimtadienis"];

                if(table.Rows[0]["lytis"].ToString() == "Female")
                {
                    radioButtonMoteris.Checked = true;
                }
                else
                {
                    radioButtonVyras.Checked = true;
                }

                byte[] pic = (byte[])table.Rows[0]["nuotrauka"];
                MemoryStream nuotrauka = new MemoryStream(pic);
                pictureBoxStudentoImg.Image = Image.FromStream(nuotrauka);

            }
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    }

