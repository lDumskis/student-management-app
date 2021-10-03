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
    public partial class PazymiaiIstrintiForm : Form
    {
        public PazymiaiIstrintiForm()
        {
            InitializeComponent();
        }

        PAZYMIAI pazymiai = new PAZYMIAI();
        private void PazymiaiIstrintiForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pazymiai.getStudentsScore();
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
    }
}
