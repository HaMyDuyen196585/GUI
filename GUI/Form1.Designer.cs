namespace GUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.bttEdit = new System.Windows.Forms.Button();
            this.cmbK = new System.Windows.Forms.ComboBox();
            this.bttD = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(256, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quan li sinh vien";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAnh);
            this.groupBox1.Controls.Add(this.bttEdit);
            this.groupBox1.Controls.Add(this.cmbK);
            this.groupBox1.Controls.Add(this.bttD);
            this.groupBox1.Controls.Add(this.bttAdd);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtDTB);
            this.groupBox1.Controls.Add(this.txtHT);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 354);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin sinh vien";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(41, 260);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(63, 22);
            this.txtAnh.TabIndex = 15;
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(110, 321);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(80, 33);
            this.bttEdit.TabIndex = 14;
            this.bttEdit.Text = "Edit";
            this.bttEdit.UseVisualStyleBackColor = true;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // cmbK
            // 
            this.cmbK.FormattingEnabled = true;
            this.cmbK.Location = new System.Drawing.Point(186, 121);
            this.cmbK.Name = "cmbK";
            this.cmbK.Size = new System.Drawing.Size(121, 24);
            this.cmbK.TabIndex = 13;
            // 
            // bttD
            // 
            this.bttD.Location = new System.Drawing.Point(196, 321);
            this.bttD.Name = "bttD";
            this.bttD.Size = new System.Drawing.Size(95, 33);
            this.bttD.TabIndex = 12;
            this.bttD.Text = "Delete";
            this.bttD.UseVisualStyleBackColor = true;
            this.bttD.Click += new System.EventHandler(this.bttD_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(13, 315);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(91, 33);
            this.bttAdd.TabIndex = 11;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(113, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 91);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(186, 162);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(100, 22);
            this.txtDTB.TabIndex = 8;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(186, 80);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(100, 22);
            this.txtHT.TabIndex = 6;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(186, 39);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(100, 22);
            this.txtMSSV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Anh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "DTB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ho Ten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(644, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Chua DKCN";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbK;
        private System.Windows.Forms.Button bttD;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.TextBox txtAnh;
    }
}

