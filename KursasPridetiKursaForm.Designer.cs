namespace ManagementBook
{
    partial class KursasPridetiKursaForm
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
            this.textBoxAprasymas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPavadinimas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownValandos = new System.Windows.Forms.NumericUpDown();
            this.buttonPridetiKursa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValandos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAprasymas
            // 
            this.textBoxAprasymas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAprasymas.Location = new System.Drawing.Point(290, 229);
            this.textBoxAprasymas.Multiline = true;
            this.textBoxAprasymas.Name = "textBoxAprasymas";
            this.textBoxAprasymas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAprasymas.Size = new System.Drawing.Size(286, 99);
            this.textBoxAprasymas.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(166, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Aprašymas: ";
            // 
            // textBoxPavadinimas
            // 
            this.textBoxPavadinimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPavadinimas.Location = new System.Drawing.Point(290, 97);
            this.textBoxPavadinimas.Name = "textBoxPavadinimas";
            this.textBoxPavadinimas.Size = new System.Drawing.Size(200, 26);
            this.textBoxPavadinimas.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pavadinimas: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Valandų skaičius: ";
            // 
            // numericUpDownValandos
            // 
            this.numericUpDownValandos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownValandos.Location = new System.Drawing.Point(290, 164);
            this.numericUpDownValandos.Name = "numericUpDownValandos";
            this.numericUpDownValandos.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownValandos.TabIndex = 17;
            // 
            // buttonPridetiKursa
            // 
            this.buttonPridetiKursa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPridetiKursa.ForeColor = System.Drawing.Color.White;
            this.buttonPridetiKursa.Location = new System.Drawing.Point(309, 359);
            this.buttonPridetiKursa.Name = "buttonPridetiKursa";
            this.buttonPridetiKursa.Size = new System.Drawing.Size(200, 36);
            this.buttonPridetiKursa.TabIndex = 18;
            this.buttonPridetiKursa.Text = "Išsaugoti";
            this.buttonPridetiKursa.UseVisualStyleBackColor = true;
            this.buttonPridetiKursa.Click += new System.EventHandler(this.ButtonPridetiKursa_Click);
            // 
            // KursasPridetiKursaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(649, 433);
            this.Controls.Add(this.buttonPridetiKursa);
            this.Controls.Add(this.numericUpDownValandos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAprasymas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPavadinimas);
            this.Controls.Add(this.label1);
            this.Name = "KursasPridetiKursaForm";
            this.Text = "KursasPridetiKursaForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValandos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAprasymas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPavadinimas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownValandos;
        private System.Windows.Forms.Button buttonPridetiKursa;
    }
}