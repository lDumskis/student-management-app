namespace ManagementBook
{
    partial class KursasIstrintiForm
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
            this.textBoxKursoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveKursas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKursoId
            // 
            this.textBoxKursoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKursoId.Location = new System.Drawing.Point(206, 63);
            this.textBoxKursoId.Name = "textBoxKursoId";
            this.textBoxKursoId.Size = new System.Drawing.Size(169, 26);
            this.textBoxKursoId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kurso ID: ";
            // 
            // buttonRemoveKursas
            // 
            this.buttonRemoveKursas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(78)))));
            this.buttonRemoveKursas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveKursas.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveKursas.Location = new System.Drawing.Point(400, 63);
            this.buttonRemoveKursas.Name = "buttonRemoveKursas";
            this.buttonRemoveKursas.Size = new System.Drawing.Size(151, 26);
            this.buttonRemoveKursas.TabIndex = 34;
            this.buttonRemoveKursas.Text = "Ištrinti";
            this.buttonRemoveKursas.UseVisualStyleBackColor = false;
            this.buttonRemoveKursas.Click += new System.EventHandler(this.ButtonRemoveKursas_Click);
            // 
            // KursasIstrintiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemoveKursas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKursoId);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "KursasIstrintiForm";
            this.Text = "KursasIstrintiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKursoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemoveKursas;
    }
}