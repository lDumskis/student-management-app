namespace ManagementBook
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.PazymiaiPanel = new System.Windows.Forms.Panel();
            this.buttonAvgScore = new System.Windows.Forms.Button();
            this.buttonEditScore = new System.Windows.Forms.Button();
            this.buttonRemoveScore = new System.Windows.Forms.Button();
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.buttonScore = new System.Windows.Forms.Button();
            this.KursasPanel = new System.Windows.Forms.Panel();
            this.buttonEditDelitCourse = new System.Windows.Forms.Button();
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.buttonRemoveCourse = new System.Windows.Forms.Button();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonCourse = new System.Windows.Forms.Button();
            this.StudentaiPanel = new System.Windows.Forms.Panel();
            this.buttonStudentForm = new System.Windows.Forms.Button();
            this.ButtonEditRemove = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonStudentList = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonStudentai = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.PazymiaiPanel.SuspendLayout();
            this.KursasPanel.SuspendLayout();
            this.StudentaiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.PazymiaiPanel);
            this.panelSideMenu.Controls.Add(this.buttonScore);
            this.panelSideMenu.Controls.Add(this.KursasPanel);
            this.panelSideMenu.Controls.Add(this.buttonCourse);
            this.panelSideMenu.Controls.Add(this.StudentaiPanel);
            this.panelSideMenu.Controls.Add(this.buttonStudentai);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(176, 619);
            this.panelSideMenu.TabIndex = 0;
            // 
            // PazymiaiPanel
            // 
            this.PazymiaiPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PazymiaiPanel.Controls.Add(this.buttonAvgScore);
            this.PazymiaiPanel.Controls.Add(this.buttonEditScore);
            this.PazymiaiPanel.Controls.Add(this.buttonRemoveScore);
            this.PazymiaiPanel.Controls.Add(this.buttonAddScore);
            this.PazymiaiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PazymiaiPanel.Location = new System.Drawing.Point(0, 480);
            this.PazymiaiPanel.Name = "PazymiaiPanel";
            this.PazymiaiPanel.Size = new System.Drawing.Size(176, 127);
            this.PazymiaiPanel.TabIndex = 5;
            // 
            // buttonAvgScore
            // 
            this.buttonAvgScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAvgScore.FlatAppearance.BorderSize = 0;
            this.buttonAvgScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvgScore.ForeColor = System.Drawing.Color.LightGray;
            this.buttonAvgScore.Location = new System.Drawing.Point(0, 90);
            this.buttonAvgScore.Name = "buttonAvgScore";
            this.buttonAvgScore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAvgScore.Size = new System.Drawing.Size(176, 30);
            this.buttonAvgScore.TabIndex = 3;
            this.buttonAvgScore.Text = "Pažimių vidurkis";
            this.buttonAvgScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAvgScore.UseVisualStyleBackColor = true;
            this.buttonAvgScore.Click += new System.EventHandler(this.ButtonAvgScore_Click);
            // 
            // buttonEditScore
            // 
            this.buttonEditScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditScore.FlatAppearance.BorderSize = 0;
            this.buttonEditScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditScore.ForeColor = System.Drawing.Color.LightGray;
            this.buttonEditScore.Location = new System.Drawing.Point(0, 60);
            this.buttonEditScore.Name = "buttonEditScore";
            this.buttonEditScore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonEditScore.Size = new System.Drawing.Size(176, 30);
            this.buttonEditScore.TabIndex = 2;
            this.buttonEditScore.Text = "Redaguoti pažimį";
            this.buttonEditScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditScore.UseVisualStyleBackColor = true;
            this.buttonEditScore.Click += new System.EventHandler(this.ButtonEditScore_Click);
            // 
            // buttonRemoveScore
            // 
            this.buttonRemoveScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRemoveScore.FlatAppearance.BorderSize = 0;
            this.buttonRemoveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveScore.ForeColor = System.Drawing.Color.LightGray;
            this.buttonRemoveScore.Location = new System.Drawing.Point(0, 30);
            this.buttonRemoveScore.Name = "buttonRemoveScore";
            this.buttonRemoveScore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonRemoveScore.Size = new System.Drawing.Size(176, 30);
            this.buttonRemoveScore.TabIndex = 1;
            this.buttonRemoveScore.Text = "Ištrinti pažimį";
            this.buttonRemoveScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveScore.UseVisualStyleBackColor = true;
            this.buttonRemoveScore.Click += new System.EventHandler(this.ButtonRemoveScore_Click);
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddScore.FlatAppearance.BorderSize = 0;
            this.buttonAddScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddScore.ForeColor = System.Drawing.Color.LightGray;
            this.buttonAddScore.Location = new System.Drawing.Point(0, 0);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAddScore.Size = new System.Drawing.Size(176, 30);
            this.buttonAddScore.TabIndex = 0;
            this.buttonAddScore.Text = "Pridėti pažimį";
            this.buttonAddScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddScore.UseVisualStyleBackColor = true;
            this.buttonAddScore.Click += new System.EventHandler(this.ButtonAddScore_Click);
            // 
            // buttonScore
            // 
            this.buttonScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonScore.FlatAppearance.BorderSize = 0;
            this.buttonScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScore.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonScore.Location = new System.Drawing.Point(0, 440);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonScore.Size = new System.Drawing.Size(176, 40);
            this.buttonScore.TabIndex = 4;
            this.buttonScore.Text = "Pažymiai";
            this.buttonScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonScore.UseVisualStyleBackColor = true;
            this.buttonScore.Click += new System.EventHandler(this.ButtonScore_Click);
            // 
            // KursasPanel
            // 
            this.KursasPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.KursasPanel.Controls.Add(this.buttonEditDelitCourse);
            this.KursasPanel.Controls.Add(this.buttonEditCourse);
            this.KursasPanel.Controls.Add(this.buttonRemoveCourse);
            this.KursasPanel.Controls.Add(this.buttonAddCourse);
            this.KursasPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KursasPanel.Location = new System.Drawing.Point(0, 313);
            this.KursasPanel.Name = "KursasPanel";
            this.KursasPanel.Size = new System.Drawing.Size(176, 127);
            this.KursasPanel.TabIndex = 3;
            // 
            // buttonEditDelitCourse
            // 
            this.buttonEditDelitCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditDelitCourse.FlatAppearance.BorderSize = 0;
            this.buttonEditDelitCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditDelitCourse.ForeColor = System.Drawing.Color.LightGray;
            this.buttonEditDelitCourse.Location = new System.Drawing.Point(0, 90);
            this.buttonEditDelitCourse.Name = "buttonEditDelitCourse";
            this.buttonEditDelitCourse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonEditDelitCourse.Size = new System.Drawing.Size(176, 30);
            this.buttonEditDelitCourse.TabIndex = 3;
            this.buttonEditDelitCourse.Text = "Pakeisti / Ištrinti";
            this.buttonEditDelitCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditDelitCourse.UseVisualStyleBackColor = true;
            this.buttonEditDelitCourse.Click += new System.EventHandler(this.ButtonEditDelitCourse_Click);
            // 
            // buttonEditCourse
            // 
            this.buttonEditCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditCourse.FlatAppearance.BorderSize = 0;
            this.buttonEditCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditCourse.ForeColor = System.Drawing.Color.LightGray;
            this.buttonEditCourse.Location = new System.Drawing.Point(0, 60);
            this.buttonEditCourse.Name = "buttonEditCourse";
            this.buttonEditCourse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonEditCourse.Size = new System.Drawing.Size(176, 30);
            this.buttonEditCourse.TabIndex = 2;
            this.buttonEditCourse.Text = "Redaguoti kursą";
            this.buttonEditCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditCourse.UseVisualStyleBackColor = true;
            this.buttonEditCourse.Click += new System.EventHandler(this.ButtonEditCourse_Click);
            // 
            // buttonRemoveCourse
            // 
            this.buttonRemoveCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRemoveCourse.FlatAppearance.BorderSize = 0;
            this.buttonRemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveCourse.ForeColor = System.Drawing.Color.LightGray;
            this.buttonRemoveCourse.Location = new System.Drawing.Point(0, 30);
            this.buttonRemoveCourse.Name = "buttonRemoveCourse";
            this.buttonRemoveCourse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonRemoveCourse.Size = new System.Drawing.Size(176, 30);
            this.buttonRemoveCourse.TabIndex = 1;
            this.buttonRemoveCourse.Text = "Ištrinti kursą";
            this.buttonRemoveCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveCourse.UseVisualStyleBackColor = true;
            this.buttonRemoveCourse.Click += new System.EventHandler(this.ButtonRemoveCourse_Click);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddCourse.FlatAppearance.BorderSize = 0;
            this.buttonAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCourse.ForeColor = System.Drawing.Color.LightGray;
            this.buttonAddCourse.Location = new System.Drawing.Point(0, 0);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAddCourse.Size = new System.Drawing.Size(176, 30);
            this.buttonAddCourse.TabIndex = 0;
            this.buttonAddCourse.Text = "Pridėti kursą";
            this.buttonAddCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.ButtonAddCourse_Click);
            // 
            // buttonCourse
            // 
            this.buttonCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCourse.FlatAppearance.BorderSize = 0;
            this.buttonCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCourse.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCourse.Location = new System.Drawing.Point(0, 273);
            this.buttonCourse.Name = "buttonCourse";
            this.buttonCourse.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCourse.Size = new System.Drawing.Size(176, 40);
            this.buttonCourse.TabIndex = 2;
            this.buttonCourse.Text = "Kursas";
            this.buttonCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCourse.UseVisualStyleBackColor = true;
            this.buttonCourse.Click += new System.EventHandler(this.ButtonCourse_Click);
            // 
            // StudentaiPanel
            // 
            this.StudentaiPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.StudentaiPanel.Controls.Add(this.buttonStudentForm);
            this.StudentaiPanel.Controls.Add(this.ButtonEditRemove);
            this.StudentaiPanel.Controls.Add(this.buttonStatistics);
            this.StudentaiPanel.Controls.Add(this.buttonStudentList);
            this.StudentaiPanel.Controls.Add(this.buttonAddStudent);
            this.StudentaiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentaiPanel.Location = new System.Drawing.Point(0, 116);
            this.StudentaiPanel.Name = "StudentaiPanel";
            this.StudentaiPanel.Size = new System.Drawing.Size(176, 157);
            this.StudentaiPanel.TabIndex = 1;
            // 
            // buttonStudentForm
            // 
            this.buttonStudentForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudentForm.FlatAppearance.BorderSize = 0;
            this.buttonStudentForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentForm.ForeColor = System.Drawing.Color.LightGray;
            this.buttonStudentForm.Location = new System.Drawing.Point(0, 120);
            this.buttonStudentForm.Name = "buttonStudentForm";
            this.buttonStudentForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonStudentForm.Size = new System.Drawing.Size(176, 30);
            this.buttonStudentForm.TabIndex = 4;
            this.buttonStudentForm.Text = "Studentų formos";
            this.buttonStudentForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentForm.UseVisualStyleBackColor = true;
            this.buttonStudentForm.Click += new System.EventHandler(this.ButtonStudentForm_Click);
            // 
            // ButtonEditRemove
            // 
            this.ButtonEditRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonEditRemove.FlatAppearance.BorderSize = 0;
            this.ButtonEditRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditRemove.ForeColor = System.Drawing.Color.LightGray;
            this.ButtonEditRemove.Location = new System.Drawing.Point(0, 90);
            this.ButtonEditRemove.Name = "ButtonEditRemove";
            this.ButtonEditRemove.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ButtonEditRemove.Size = new System.Drawing.Size(176, 30);
            this.ButtonEditRemove.TabIndex = 3;
            this.ButtonEditRemove.Text = "Pakeisti / Ištrinti";
            this.ButtonEditRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEditRemove.UseVisualStyleBackColor = true;
            this.ButtonEditRemove.Click += new System.EventHandler(this.ButtonEditRemove_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.ForeColor = System.Drawing.Color.LightGray;
            this.buttonStatistics.Location = new System.Drawing.Point(0, 60);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonStatistics.Size = new System.Drawing.Size(176, 30);
            this.buttonStatistics.TabIndex = 2;
            this.buttonStatistics.Text = "Statistika";
            this.buttonStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.ButtonStatistics_Click);
            // 
            // buttonStudentList
            // 
            this.buttonStudentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudentList.FlatAppearance.BorderSize = 0;
            this.buttonStudentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentList.ForeColor = System.Drawing.Color.LightGray;
            this.buttonStudentList.Location = new System.Drawing.Point(0, 30);
            this.buttonStudentList.Name = "buttonStudentList";
            this.buttonStudentList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonStudentList.Size = new System.Drawing.Size(176, 30);
            this.buttonStudentList.TabIndex = 1;
            this.buttonStudentList.Text = "Studentų sąrašas";
            this.buttonStudentList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentList.UseVisualStyleBackColor = true;
            this.buttonStudentList.Click += new System.EventHandler(this.ButtonStudentList_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddStudent.FlatAppearance.BorderSize = 0;
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudent.ForeColor = System.Drawing.Color.LightGray;
            this.buttonAddStudent.Location = new System.Drawing.Point(0, 0);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAddStudent.Size = new System.Drawing.Size(176, 30);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "Pridėti studentą";
            this.buttonAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // buttonStudentai
            // 
            this.buttonStudentai.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudentai.FlatAppearance.BorderSize = 0;
            this.buttonStudentai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentai.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStudentai.Location = new System.Drawing.Point(0, 76);
            this.buttonStudentai.Name = "buttonStudentai";
            this.buttonStudentai.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonStudentai.Size = new System.Drawing.Size(176, 40);
            this.buttonStudentai.TabIndex = 0;
            this.buttonStudentai.Text = "Studentai";
            this.buttonStudentai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentai.UseVisualStyleBackColor = true;
            this.buttonStudentai.Click += new System.EventHandler(this.ButtonStudentai_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(176, 76);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(176, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(910, 619);
            this.panelChildForm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 619);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelSideMenu.ResumeLayout(false);
            this.PazymiaiPanel.ResumeLayout(false);
            this.KursasPanel.ResumeLayout(false);
            this.StudentaiPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel PazymiaiPanel;
        private System.Windows.Forms.Button buttonAvgScore;
        private System.Windows.Forms.Button buttonEditScore;
        private System.Windows.Forms.Button buttonRemoveScore;
        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.Button buttonScore;
        private System.Windows.Forms.Panel KursasPanel;
        private System.Windows.Forms.Button buttonEditDelitCourse;
        private System.Windows.Forms.Button buttonEditCourse;
        private System.Windows.Forms.Button buttonRemoveCourse;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button buttonCourse;
        private System.Windows.Forms.Panel StudentaiPanel;
        private System.Windows.Forms.Button buttonStudentForm;
        private System.Windows.Forms.Button ButtonEditRemove;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonStudentList;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonStudentai;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
    }
}