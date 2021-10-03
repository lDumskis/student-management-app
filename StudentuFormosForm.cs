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
    public partial class StudentuFormosForm : Form
    {
        public StudentuFormosForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void StudentuFormosForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM Studentai"));
        }

        // funkcija uzpildyti datagridview
        public void fillGrid(SqlCommand query)
        {
            DataGridViewImageColumn nuotraukaCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(query);
            nuotraukaCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            nuotraukaCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

            // rodomas skaicius studentu priklausomai nuo rodomu eiluciu
            labelTotalStudents.Text = "Viso studentų: " + dataGridView1.Rows.Count;

        }


        private void DataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxVardas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxPavarde.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Moteris")
            {
                radioButtonMoteris.Checked = true;
            }
            else
            {
                radioButtonVyras.Checked = true;
            }
     
            textBoxTelefonas.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxAdresas.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] nuotrauka;
            nuotrauka = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(nuotrauka);
            pictureBoxStudentoImg.Image = Image.FromStream(picture);

        }
        // isvlayti
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxVardas.Text = "";
            textBoxPavarde.Text = "";
            textBoxTelefonas.Text = "";
            textBoxAdresas.Text = "";
            radioButtonVyras.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBoxStudentoImg.Image = null;
        }

        // prideti nuotrauka
        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pasirinkite nuotrauka(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentoImg.Image = Image.FromFile(opf.FileName);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
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

            if (((dabartiniai_metai - gimimo_metai) < 10) || ((dabartiniai_metai - gimimo_metai) > 100))
            {
                MessageBox.Show("Studento amžius negali būti mažesnis už 10 bei didesnis už 100", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (verif())
            {
                pictureBoxStudentoImg.Image.Save(nuotrauka, pictureBoxStudentoImg.Image.RawFormat);

                if (student.insertStudent(vardas, pavarde, gimtadienis, telefonas, lytis, adresas, nuotrauka))
                {
                    MessageBox.Show("Naujas studentas pridėtas", "Pridėti studentą", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("SELECT * FROM Studentai"));
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

        private void ButtonEdit_Click(object sender, EventArgs e)
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
                    fillGrid(new SqlCommand("SELECT * FROM Studentai"));
                }
            }
            else
            {
                MessageBox.Show("Tuščias laukelis", "Pridėti studentą", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);

            if (MessageBox.Show("Ar tikrai norite ištrinti studentą?", "Ištrinti studentą", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (student.deleteStudent(id))
                {
                    MessageBox.Show("Studentas ištrintas", "Ištrinti studentą", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("SELECT * FROM Studentai"));

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

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string command = "SELECT* FROM Studentai WHERE CONCAT(Vardas, Pavarde, Adresas) LIKE '%" + textBoxSearch.Text + "%'";
            SqlCommand query = new SqlCommand(command);
            fillGrid(query);
        }
    }
}
