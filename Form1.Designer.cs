namespace HRApp
{
    partial class hrForm
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
            this.lbLogo = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbDept = new System.Windows.Forms.Label();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Location = new System.Drawing.Point(51, 41);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(54, 13);
            this.lbLogo.TabIndex = 0;
            this.lbLogo.Text = "HRCheck";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(51, 88);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(94, 13);
            this.lbNama.TabIndex = 1;
            this.lbNama.Text = "Nama Karyawan : ";
            // 
            // lbDept
            // 
            this.lbDept.AutoSize = true;
            this.lbDept.Location = new System.Drawing.Point(51, 123);
            this.lbDept.Name = "lbDept";
            this.lbDept.Size = new System.Drawing.Size(89, 13);
            this.lbDept.TabIndex = 2;
            this.lbDept.Text = "Dep. Karyawan : ";
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Items.AddRange(new object[] {
            "HR",
            "ENG",
            "DEV",
            "PM",
            "FIN"});
            this.cbDept.Location = new System.Drawing.Point(158, 120);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(121, 21);
            this.cbDept.TabIndex = 3;
            this.cbDept.Text = "Pilih Departemen";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(158, 85);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(121, 20);
            this.tbNama.TabIndex = 4;
            this.tbNama.Text = "Masukkan Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Departemen:\r\nHR : HR\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product Manager\r\nF" +
    "IN : Finance\r\n";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(54, 181);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(204, 181);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(357, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvData
            // 
            this.dgvData.Location = new System.Drawing.Point(54, 228);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(414, 150);
            this.dgvData.TabIndex = 0;
            // 
            // hrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 406);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.lbDept);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbLogo);
            this.Name = "hrForm";
            this.Text = "Data Karyawan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbDept;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvData;
    }
}

