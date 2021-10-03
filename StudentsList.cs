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
    public partial class StudentsList : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\X\Documents\DB.mdf;Integrated Security = True; Connect Timeout = 30");

        public StudentsList()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void StudentsList_Load_1(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("SELECT * FROM Studentai", con);
            DataGridViewImageColumn nuotraukaCol = new DataGridViewImageColumn();
            dataGridViewStudentaiList.RowTemplate.Height = 80;
            dataGridViewStudentaiList.DataSource = student.getStudents(query);
            nuotraukaCol = (DataGridViewImageColumn)dataGridViewStudentaiList.Columns[7];
            nuotraukaCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewStudentaiList.AllowUserToAddRows = false;
        }

        private void DataGridViewStudentaiList_DoubleClick(object sender, EventArgs e)
        {
            StudentaiEditRemoveForm updateDeleteStdF = new StudentaiEditRemoveForm();
            updateDeleteStdF.textBoxID.Text = dataGridViewStudentaiList.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStdF.textBoxVardas.Text = dataGridViewStudentaiList.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdF.textBoxPavarde.Text = dataGridViewStudentaiList.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdF.dateTimePicker1.Value = (DateTime)dataGridViewStudentaiList.CurrentRow.Cells[3].Value;

            if (dataGridViewStudentaiList.CurrentRow.Cells[4].Value.ToString() == "Female")
                {
                    updateDeleteStdF.radioButtonMoteris.Checked = true;
                }

            updateDeleteStdF.textBoxTelefonas.Text = dataGridViewStudentaiList.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStdF.textBoxAdresas.Text = dataGridViewStudentaiList.CurrentRow.Cells[6].Value.ToString();

                byte[] nuotrauka;
                nuotrauka =(byte[]) dataGridViewStudentaiList.CurrentRow.Cells[7].Value;
                MemoryStream picture = new MemoryStream(nuotrauka);
                updateDeleteStdF.pictureBoxStudentoImg.Image = Image.FromStream(picture);
                updateDeleteStdF.Show();

            }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("SELECT * FROM Studentai", con);
            DataGridViewImageColumn nuotraukaCol = new DataGridViewImageColumn();
            dataGridViewStudentaiList.RowTemplate.Height = 80;
            dataGridViewStudentaiList.DataSource = student.getStudents(query);
            nuotraukaCol = (DataGridViewImageColumn)dataGridViewStudentaiList.Columns[7];
            nuotraukaCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewStudentaiList.AllowUserToAddRows = false;
        }
    }
    }

