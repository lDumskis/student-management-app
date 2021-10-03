namespace ManagementBook
{
    partial class PazymiaiIstrintiForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRemovePazymi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1023, 530);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonRemovePazymi
            // 
            this.buttonRemovePazymi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(78)))));
            this.buttonRemovePazymi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonRemovePazymi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemovePazymi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemovePazymi.ForeColor = System.Drawing.Color.White;
            this.buttonRemovePazymi.Location = new System.Drawing.Point(0, 536);
            this.buttonRemovePazymi.Name = "buttonRemovePazymi";
            this.buttonRemovePazymi.Size = new System.Drawing.Size(1023, 83);
            this.buttonRemovePazymi.TabIndex = 35;
            this.buttonRemovePazymi.Text = "Ištrinti pažimį";
            this.buttonRemovePazymi.UseVisualStyleBackColor = false;
            this.buttonRemovePazymi.Click += new System.EventHandler(this.ButtonRemovePazymi_Click);
            // 
            // PazymiaiIstrintiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1023, 619);
            this.Controls.Add(this.buttonRemovePazymi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PazymiaiIstrintiForm";
            this.Text = "PazymiaiIstrintiForm";
            this.Load += new System.EventHandler(this.PazymiaiIstrintiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRemovePazymi;
    }
}