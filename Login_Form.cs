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
    public partial class Login_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\X\Documents\DB.mdf;Integrated Security = True; Connect Timeout = 30");

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../images/user.png");
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Count(*) FROM users WHERE Username ='" + textBoxUsername.Text + "' and Password = '" + textBoxPassword.Text + "'", con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows[0][0].ToString() == "1")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Neteisingas prisijungimo vardas arba slaptažodis");
            }
            
        }
    }
}
