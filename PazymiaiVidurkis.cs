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
    public partial class PazymiaiVidurkis : Form
    {
        public PazymiaiVidurkis()
        {
            InitializeComponent();
        }

        private void PazymiaiVidurkis_Load(object sender, EventArgs e)
        {
            PAZYMIAI pazymiai = new PAZYMIAI();
            dataGridView1.DataSource = pazymiai.avgScoreByCourse();
        }
    }
}
