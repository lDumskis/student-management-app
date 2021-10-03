namespace ManagementBook
{
    partial class StudentsList
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
            this.dataGridViewStudentaiList = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentaiList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentaiList
            // 
            this.dataGridViewStudentaiList.AllowUserToAddRows = false;
            this.dataGridViewStudentaiList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentaiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentaiList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudentaiList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStudentaiList.Name = "dataGridViewStudentaiList";
            this.dataGridViewStudentaiList.ReadOnly = true;
            this.dataGridViewStudentaiList.Size = new System.Drawing.Size(719, 435);
            this.dataGridViewStudentaiList.TabIndex = 0;
            this.dataGridViewStudentaiList.DoubleClick += new System.EventHandler(this.DataGridViewStudentaiList_DoubleClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(0, 385);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(719, 50);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Atnaujinti";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 435);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewStudentaiList);
            this.Name = "StudentsList";
            this.Text = "StudentsList";
            this.Load += new System.EventHandler(this.StudentsList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentaiList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudentaiList;
        private System.Windows.Forms.Button buttonRefresh;
    }
}