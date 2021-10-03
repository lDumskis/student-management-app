namespace ManagementBook
{
    partial class RedaguotiForm
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
            this.buttonAtnaujintiKursa = new System.Windows.Forms.Button();
            this.numericUpDownValandos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAprasymas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPavadinimas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKursas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValandos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAtnaujintiKursa
            // 
            this.buttonAtnaujintiKursa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtnaujintiKursa.ForeColor = System.Drawing.Color.White;
            this.buttonAtnaujintiKursa.Location = new System.Drawing.Point(275, 369);
            this.buttonAtnaujintiKursa.Name = "buttonAtnaujintiKursa";
            this.buttonAtnaujintiKursa.Size = new System.Drawing.Size(200, 36);
            this.buttonAtnaujintiKursa.TabIndex = 25;
            this.buttonAtnaujintiKursa.Text = "Išsaugoti";
            this.buttonAtnaujintiKursa.UseVisualStyleBackColor = true;
            this.buttonAtnaujintiKursa.Click += new System.EventHandler(this.ButtonAtnaujintiKursa_Click);
            // 
            // numericUpDownValandos
            // 
            this.numericUpDownValandos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownValandos.Location = new System.Drawing.Point(275, 165);
            this.numericUpDownValandos.Name = "numericUpDownValandos";
            this.numericUpDownValandos.Size = new System.Drawing.Size(147, 26);
            this.numericUpDownValandos.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Valandų skaičius: ";
            // 
            // textBoxAprasymas
            // 
            this.textBoxAprasymas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAprasymas.Location = new System.Drawing.Point(275, 230);
            this.textBoxAprasymas.Multiline = true;
            this.textBoxAprasymas.Name = "textBoxAprasymas";
            this.textBoxAprasymas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAprasymas.Size = new System.Drawing.Size(286, 99);
            this.textBoxAprasymas.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(151, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Aprašymas: ";
            // 
            // textBoxPavadinimas
            // 
            this.textBoxPavadinimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPavadinimas.Location = new System.Drawing.Point(275, 98);
            this.textBoxPavadinimas.Name = "textBoxPavadinimas";
            this.textBoxPavadinimas.Size = new System.Drawing.Size(200, 26);
            this.textBoxPavadinimas.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pavadinimas: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Pasirinkite kursą: ";
            // 
            // comboBoxKursas
            // 
            this.comboBoxKursas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKursas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKursas.FormattingEnabled = true;
            this.comboBoxKursas.Location = new System.Drawing.Point(275, 47);
            this.comboBoxKursas.Name = "comboBoxKursas";
            this.comboBoxKursas.Size = new System.Drawing.Size(200, 28);
            this.comboBoxKursas.TabIndex = 27;
            this.comboBoxKursas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKursas_SelectedIndexChanged_1);
            // 
            // RedaguotiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.comboBoxKursas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAtnaujintiKursa);
            this.Controls.Add(this.numericUpDownValandos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAprasymas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPavadinimas);
            this.Controls.Add(this.label1);
            this.Name = "RedaguotiForm";
            this.Text = "RedaguotiForm";
            this.Load += new System.EventHandler(this.RedaguotiForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValandos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtnaujintiKursa;
        private System.Windows.Forms.NumericUpDown numericUpDownValandos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAprasymas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPavadinimas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox comboBoxKursas;
    }
}