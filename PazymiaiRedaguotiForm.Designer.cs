namespace ManagementBook
{
    partial class PazymiaiRedaguotiForm
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
            this.buttonPridetiPazymi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxPazimys = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKursas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAprasymas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStudentoID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemovePazymi = new System.Windows.Forms.Button();
            this.buttonPazVidurkis = new System.Windows.Forms.Button();
            this.buttonRodytiStudentus = new System.Windows.Forms.Button();
            this.buttonRodytiPazymius = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPridetiPazymi
            // 
            this.buttonPridetiPazymi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(78)))));
            this.buttonPridetiPazymi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPridetiPazymi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPridetiPazymi.ForeColor = System.Drawing.Color.White;
            this.buttonPridetiPazymi.Location = new System.Drawing.Point(24, 420);
            this.buttonPridetiPazymi.Name = "buttonPridetiPazymi";
            this.buttonPridetiPazymi.Size = new System.Drawing.Size(103, 36);
            this.buttonPridetiPazymi.TabIndex = 47;
            this.buttonPridetiPazymi.Text = "Pridėti";
            this.buttonPridetiPazymi.UseVisualStyleBackColor = false;
            this.buttonPridetiPazymi.Click += new System.EventHandler(this.ButtonPridetiPazymi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 430);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            // 
            // textBoxPazimys
            // 
            this.textBoxPazimys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPazimys.Location = new System.Drawing.Point(24, 246);
            this.textBoxPazimys.Name = "textBoxPazimys";
            this.textBoxPazimys.Size = new System.Drawing.Size(204, 26);
            this.textBoxPazimys.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Pažymys: ";
            // 
            // comboBoxKursas
            // 
            this.comboBoxKursas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKursas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKursas.FormattingEnabled = true;
            this.comboBoxKursas.Location = new System.Drawing.Point(24, 165);
            this.comboBoxKursas.Name = "comboBoxKursas";
            this.comboBoxKursas.Size = new System.Drawing.Size(147, 28);
            this.comboBoxKursas.TabIndex = 43;
            this.comboBoxKursas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKursas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Pasirinkite kursą: ";
            // 
            // textBoxAprasymas
            // 
            this.textBoxAprasymas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAprasymas.Location = new System.Drawing.Point(24, 329);
            this.textBoxAprasymas.Multiline = true;
            this.textBoxAprasymas.Name = "textBoxAprasymas";
            this.textBoxAprasymas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAprasymas.Size = new System.Drawing.Size(204, 58);
            this.textBoxAprasymas.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Aprašymas: ";
            // 
            // textBoxStudentoID
            // 
            this.textBoxStudentoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentoID.Location = new System.Drawing.Point(24, 87);
            this.textBoxStudentoID.Name = "textBoxStudentoID";
            this.textBoxStudentoID.Size = new System.Drawing.Size(145, 26);
            this.textBoxStudentoID.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Studento ID:";
            // 
            // buttonRemovePazymi
            // 
            this.buttonRemovePazymi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(78)))));
            this.buttonRemovePazymi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemovePazymi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemovePazymi.ForeColor = System.Drawing.Color.White;
            this.buttonRemovePazymi.Location = new System.Drawing.Point(145, 420);
            this.buttonRemovePazymi.Name = "buttonRemovePazymi";
            this.buttonRemovePazymi.Size = new System.Drawing.Size(103, 36);
            this.buttonRemovePazymi.TabIndex = 48;
            this.buttonRemovePazymi.Text = "Ištrinti";
            this.buttonRemovePazymi.UseVisualStyleBackColor = false;
            this.buttonRemovePazymi.Click += new System.EventHandler(this.ButtonRemovePazymi_Click);
            // 
            // buttonPazVidurkis
            // 
            this.buttonPazVidurkis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(78)))));
            this.buttonPazVidurkis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPazVidurkis.ForeColor = System.Drawing.Color.White;
            this.buttonPazVidurkis.Location = new System.Drawing.Point(24, 481);
            this.buttonPazVidurkis.Name = "buttonPazVidurkis";
            this.buttonPazVidurkis.Size = new System.Drawing.Size(224, 36);
            this.buttonPazVidurkis.TabIndex = 49;
            this.buttonPazVidurkis.Text = "Vidurkis pagal kursą";
            this.buttonPazVidurkis.UseVisualStyleBackColor = false;
            this.buttonPazVidurkis.Click += new System.EventHandler(this.ButtonPazVidurkis_Click);
            // 
            // buttonRodytiStudentus
            // 
            this.buttonRodytiStudentus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.buttonRodytiStudentus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRodytiStudentus.ForeColor = System.Drawing.Color.White;
            this.buttonRodytiStudentus.Location = new System.Drawing.Point(280, 52);
            this.buttonRodytiStudentus.Name = "buttonRodytiStudentus";
            this.buttonRodytiStudentus.Size = new System.Drawing.Size(224, 29);
            this.buttonRodytiStudentus.TabIndex = 50;
            this.buttonRodytiStudentus.Text = "Studentai";
            this.buttonRodytiStudentus.UseVisualStyleBackColor = false;
            this.buttonRodytiStudentus.Click += new System.EventHandler(this.ButtonRodytiStudentus_Click);
            // 
            // buttonRodytiPazymius
            // 
            this.buttonRodytiPazymius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.buttonRodytiPazymius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRodytiPazymius.ForeColor = System.Drawing.Color.White;
            this.buttonRodytiPazymius.Location = new System.Drawing.Point(749, 52);
            this.buttonRodytiPazymius.Name = "buttonRodytiPazymius";
            this.buttonRodytiPazymius.Size = new System.Drawing.Size(224, 29);
            this.buttonRodytiPazymius.TabIndex = 51;
            this.buttonRodytiPazymius.Text = "Pažymiai";
            this.buttonRodytiPazymius.UseVisualStyleBackColor = false;
            this.buttonRodytiPazymius.Click += new System.EventHandler(this.ButtonRodytiPazymius_Click);
            // 
            // PazymiaiRedaguotiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(998, 599);
            this.Controls.Add(this.buttonRodytiPazymius);
            this.Controls.Add(this.buttonRodytiStudentus);
            this.Controls.Add(this.buttonPazVidurkis);
            this.Controls.Add(this.buttonRemovePazymi);
            this.Controls.Add(this.buttonPridetiPazymi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxPazimys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxKursas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAprasymas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxStudentoID);
            this.Controls.Add(this.label1);
            this.Name = "PazymiaiRedaguotiForm";
            this.Text = "PazymiaiRedaguotiForm";
            this.Load += new System.EventHandler(this.PazymiaiRedaguotiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPridetiPazymi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxPazimys;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox comboBoxKursas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAprasymas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStudentoID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemovePazymi;
        private System.Windows.Forms.Button buttonPazVidurkis;
        private System.Windows.Forms.Button buttonRodytiStudentus;
        private System.Windows.Forms.Button buttonRodytiPazymius;
    }
}