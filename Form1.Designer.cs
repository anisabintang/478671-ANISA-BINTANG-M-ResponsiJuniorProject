namespace HRApps
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbNama = new System.Windows.Forms.Label();
            lbDep = new System.Windows.Forms.Label();
            tbNama = new System.Windows.Forms.TextBox();
            dataGridView = new System.Windows.Forms.DataGridView();
            btnInsert = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            lbKet = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbLogo = new System.Windows.Forms.Label();
            tbDep = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbNama
            // 
            lbNama.AutoSize = true;
            lbNama.Location = new System.Drawing.Point(12, 77);
            lbNama.Name = "lbNama";
            lbNama.Size = new System.Drawing.Size(99, 15);
            lbNama.TabIndex = 0;
            lbNama.Text = "Nama Karyawan :";
            // 
            // lbDep
            // 
            lbDep.AutoSize = true;
            lbDep.Location = new System.Drawing.Point(20, 120);
            lbDep.Name = "lbDep";
            lbDep.Size = new System.Drawing.Size(91, 15);
            lbDep.TabIndex = 1;
            lbDep.Text = "Dep. Karyawan :";
            // 
            // tbNama
            // 
            tbNama.Location = new System.Drawing.Point(126, 71);
            tbNama.Name = "tbNama";
            tbNama.Size = new System.Drawing.Size(100, 23);
            tbNama.TabIndex = 2;
            tbNama.TextChanged += tbNama_TextChanged;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new System.Drawing.Point(12, 222);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new System.Drawing.Size(776, 216);
            dataGridView.TabIndex = 4;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(237, 184);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(82, 32);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(340, 184);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(82, 32);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(445, 184);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(82, 32);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbKet
            // 
            lbKet.AutoSize = true;
            lbKet.Location = new System.Drawing.Point(594, 41);
            lbKet.Name = "lbKet";
            lbKet.Size = new System.Drawing.Size(89, 15);
            lbKet.TabIndex = 9;
            lbKet.Text = "ID Departemen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(594, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 15);
            label1.TabIndex = 10;
            label1.Text = "ENG:Engineer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(594, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 15);
            label2.TabIndex = 11;
            label2.Text = "HR:HR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(594, 86);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 15);
            label3.TabIndex = 12;
            label3.Text = "DEV: Developer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(594, 101);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(120, 15);
            label4.TabIndex = 13;
            label4.Text = "PM:Product Manager";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(594, 116);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 15);
            label5.TabIndex = 14;
            label5.Text = "FIN:Finance";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            pictureBox1.BackgroundImage = Properties.Resources.Picture1;
            pictureBox1.Location = new System.Drawing.Point(20, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 50);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Location = new System.Drawing.Point(139, 22);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new System.Drawing.Size(34, 15);
            lbLogo.TabIndex = 17;
            lbLogo.Text = "Logo";
            // 
            // tbDep
            // 
            tbDep.Location = new System.Drawing.Point(126, 113);
            tbDep.Name = "tbDep";
            tbDep.Size = new System.Drawing.Size(100, 23);
            tbDep.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tbDep);
            Controls.Add(lbLogo);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbKet);
            Controls.Add(btnUpdate);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView);
            Controls.Add(tbNama);
            Controls.Add(lbDep);
            Controls.Add(lbNama);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbDep;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbKet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.TextBox tbDep;
    }
}
