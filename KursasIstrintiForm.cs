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
    public partial class KursasIstrintiForm : Form
    {
        public KursasIstrintiForm()
        {
            InitializeComponent();
        }

        private void ButtonRemoveKursas_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxKursoId.Text);

            KURSAS kursas = new KURSAS();

            if (MessageBox.Show("Ar tikrai norite ištrinti kursą?", "Ištrinti kursą", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (kursas.deleteKursas(id))
                {
                    MessageBox.Show("Kursas ištrintas", "Ištrinti kursą", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ištrinti kurso nepavyko", "Ištrinti kursą",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
