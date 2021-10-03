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
    public partial class StudentaiStatistikaForm : Form
    {
        public StudentaiStatistikaForm()
        {
            InitializeComponent();
        }

        Color panTotalColor;
        Color panMoterysColor;
        Color panVyraiColor;

        private void StudentaiStatistikaForm_Load(object sender, EventArgs e)
        {

            // priskiriamos spalvos kintamiesiems
            panTotalColor = panelTotal.BackColor;
            panMoterysColor = panelMoterys.BackColor;
            panVyraiColor = panelVyrai.BackColor;


            // atvaizduojamos reiksmes
            STUDENT student = new STUDENT();
            double TotalStudents = Convert.ToDouble(student.totalStudent());
            double totalVyruStudent = Convert.ToDouble(student.totalVyruStudent());
            double totalMoteruStudent = Convert.ToDouble(student.totalMoteruStudent());

            // skaiciuojamas procentas
            double vyruProcentai = totalVyruStudent * 100 / TotalStudents;
            double moteruProcentai = totalMoteruStudent * 100 / TotalStudents;

            labelTotal.Text = "Viso studentu: " + TotalStudents.ToString();
            labelMoterys.Text = "Moterys: " + moteruProcentai.ToString("0.00") + " % ";
            labelVyrai.Text = "Vyrai: " + vyruProcentai.ToString("0.00") + " % ";
        }

        private void LabelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.White;
            labelTotal.ForeColor = panTotalColor;
        }

        private void LabelTotal_MouseLeave(object sender, EventArgs e)
        {
            panelTotal.BackColor = panTotalColor;
            labelTotal.ForeColor = Color.White;
        }

        private void LabelVyrai_MouseEnter(object sender, EventArgs e)
        {
            panelVyrai.BackColor = Color.White;
            labelVyrai.ForeColor = panVyraiColor;
        }

        private void LabelVyrai_MouseLeave(object sender, EventArgs e)
        {
            panelVyrai.BackColor = panVyraiColor;
            labelVyrai.ForeColor = Color.White;
        }

        private void LabelMoterys_MouseEnter(object sender, EventArgs e)
        {
            panelMoterys.BackColor = Color.White;
            labelMoterys.ForeColor = panMoterysColor;
        }

        private void LabelMoterys_MouseLeave(object sender, EventArgs e)
        {
            panelMoterys.BackColor = panMoterysColor;
            labelMoterys.ForeColor = Color.White;
        }
    }
}
