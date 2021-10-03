namespace ManagementBook
{
    partial class StudentaiStatistikaForm
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
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelVyrai = new System.Windows.Forms.Panel();
            this.labelVyrai = new System.Windows.Forms.Label();
            this.panelMoterys = new System.Windows.Forms.Panel();
            this.labelMoterys = new System.Windows.Forms.Label();
            this.panelTotal.SuspendLayout();
            this.panelVyrai.SuspendLayout();
            this.panelMoterys.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTotal.Location = new System.Drawing.Point(0, 0);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(773, 182);
            this.panelTotal.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(0, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(773, 182);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Studentų skaičius: 100";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotal.MouseEnter += new System.EventHandler(this.LabelTotal_MouseEnter);
            this.labelTotal.MouseLeave += new System.EventHandler(this.LabelTotal_MouseLeave);
            // 
            // panelVyrai
            // 
            this.panelVyrai.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelVyrai.Controls.Add(this.labelVyrai);
            this.panelVyrai.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVyrai.Location = new System.Drawing.Point(0, 182);
            this.panelVyrai.Name = "panelVyrai";
            this.panelVyrai.Size = new System.Drawing.Size(355, 297);
            this.panelVyrai.TabIndex = 1;
            // 
            // labelVyrai
            // 
            this.labelVyrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVyrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVyrai.ForeColor = System.Drawing.Color.White;
            this.labelVyrai.Location = new System.Drawing.Point(0, 0);
            this.labelVyrai.Name = "labelVyrai";
            this.labelVyrai.Size = new System.Drawing.Size(355, 297);
            this.labelVyrai.TabIndex = 1;
            this.labelVyrai.Text = "Vyrų: 50%";
            this.labelVyrai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVyrai.MouseEnter += new System.EventHandler(this.LabelVyrai_MouseEnter);
            this.labelVyrai.MouseLeave += new System.EventHandler(this.LabelVyrai_MouseLeave);
            // 
            // panelMoterys
            // 
            this.panelMoterys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panelMoterys.Controls.Add(this.labelMoterys);
            this.panelMoterys.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMoterys.Location = new System.Drawing.Point(428, 182);
            this.panelMoterys.Name = "panelMoterys";
            this.panelMoterys.Size = new System.Drawing.Size(345, 297);
            this.panelMoterys.TabIndex = 2;
            // 
            // labelMoterys
            // 
            this.labelMoterys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMoterys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoterys.ForeColor = System.Drawing.Color.White;
            this.labelMoterys.Location = new System.Drawing.Point(0, 0);
            this.labelMoterys.Name = "labelMoterys";
            this.labelMoterys.Size = new System.Drawing.Size(345, 297);
            this.labelMoterys.TabIndex = 2;
            this.labelMoterys.Text = "Moterų: 50%";
            this.labelMoterys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMoterys.MouseEnter += new System.EventHandler(this.LabelMoterys_MouseEnter);
            this.labelMoterys.MouseLeave += new System.EventHandler(this.LabelMoterys_MouseLeave);
            // 
            // StudentaiStatistikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(773, 479);
            this.Controls.Add(this.panelMoterys);
            this.Controls.Add(this.panelVyrai);
            this.Controls.Add(this.panelTotal);
            this.Name = "StudentaiStatistikaForm";
            this.Text = "StudentaiStatistikaForm";
            this.Load += new System.EventHandler(this.StudentaiStatistikaForm_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelVyrai.ResumeLayout(false);
            this.panelMoterys.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelVyrai;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelVyrai;
        private System.Windows.Forms.Panel panelMoterys;
        private System.Windows.Forms.Label labelMoterys;
    }
}