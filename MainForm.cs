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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();

        }
        private void customizeDesign()
        {
            StudentaiPanel.Visible = false;
            KursasPanel.Visible = false;
            PazymiaiPanel.Visible = false;
        }
        private void hideSubMenu()
        {
            if (StudentaiPanel.Visible == true)
                StudentaiPanel.Visible = false;
            if (KursasPanel.Visible == true)
                KursasPanel.Visible = false;
            if (PazymiaiPanel.Visible == true)
                PazymiaiPanel.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void ButtonStudentai_Click(object sender, EventArgs e)
        {
            ShowSubMenu(StudentaiPanel);
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            openChildFrom(new addStudent());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonStudentList_Click(object sender, EventArgs e)
        {
            openChildFrom(new StudentsList());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonStatistics_Click(object sender, EventArgs e)
        {
            openChildFrom(new StudentaiStatistikaForm());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonEditRemove_Click(object sender, EventArgs e)
        {
            openChildFrom(new StudentaiEditRemoveForm());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonStudentForm_Click(object sender, EventArgs e)
        {
            openChildFrom(new StudentuFormosForm());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
            openChildFrom(new KursasPridetiKursaForm());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonRemoveCourse_Click(object sender, EventArgs e)
        {
            openChildFrom(new KursasIstrintiForm());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonEditCourse_Click(object sender, EventArgs e)
        {
            openChildFrom(new RedaguotiForm());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonEditDelitCourse_Click(object sender, EventArgs e)
        {
            openChildFrom(new KursasKeistiTrintiForm());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonAddScore_Click(object sender, EventArgs e)
        {
            openChildFrom(new PazymiaiPridetiForm());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonRemoveScore_Click(object sender, EventArgs e)
        {
            openChildFrom(new PazymiaiIstrintiForm());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonEditScore_Click(object sender, EventArgs e)
        {
            openChildFrom(new PazymiaiRedaguotiForm());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonAvgScore_Click(object sender, EventArgs e)
        {
            openChildFrom(new PazymiaiVidurkis());
            //
            //
            //
            hideSubMenu();
        }

        private void ButtonCourse_Click(object sender, EventArgs e)
        {
            ShowSubMenu(KursasPanel);
        }

        private void ButtonScore_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PazymiaiPanel);
        }

  
        private void openChildFrom(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}
