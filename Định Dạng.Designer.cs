namespace PhanKimHoangPhuc_15_ThiCSharp
{
    partial class frmDinhDang
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radred = new System.Windows.Forms.RadioButton();
            this.radgreen = new System.Windows.Forms.RadioButton();
            this.radblue = new System.Windows.Forms.RadioButton();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbbold = new System.Windows.Forms.CheckBox();
            this.ckbitalic = new System.Windows.Forms.CheckBox();
            this.ckbunderLine = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlaptrinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên:";
            // 
            // txtnhapten
            // 
            this.txtnhapten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhapten.ForeColor = System.Drawing.Color.Red;
            this.txtnhapten.Location = new System.Drawing.Point(166, 54);
            this.txtnhapten.Multiline = true;
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(350, 28);
            this.txtnhapten.TabIndex = 1;
            this.txtnhapten.Text = "DE Thi 2023";
            this.txtnhapten.TextChanged += new System.EventHandler(this.txtnhapten_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.radblack);
            this.groupBox1.Controls.Add(this.radblue);
            this.groupBox1.Controls.Add(this.radgreen);
            this.groupBox1.Controls.Add(this.radred);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // radred
            // 
            this.radred.AutoSize = true;
            this.radred.ForeColor = System.Drawing.Color.Red;
            this.radred.Location = new System.Drawing.Point(23, 37);
            this.radred.Name = "radred";
            this.radred.Size = new System.Drawing.Size(55, 21);
            this.radred.TabIndex = 0;
            this.radred.TabStop = true;
            this.radred.Text = "Red";
            this.radred.UseVisualStyleBackColor = true;
            this.radred.CheckedChanged += new System.EventHandler(this.radred_CheckedChanged);
            // 
            // radgreen
            // 
            this.radgreen.AutoSize = true;
            this.radgreen.ForeColor = System.Drawing.Color.Green;
            this.radgreen.Location = new System.Drawing.Point(23, 88);
            this.radgreen.Name = "radgreen";
            this.radgreen.Size = new System.Drawing.Size(71, 21);
            this.radgreen.TabIndex = 1;
            this.radgreen.TabStop = true;
            this.radgreen.Text = "Green";
            this.radgreen.UseVisualStyleBackColor = true;
            this.radgreen.CheckedChanged += new System.EventHandler(this.radgreen_CheckedChanged);
            // 
            // radblue
            // 
            this.radblue.AutoSize = true;
            this.radblue.ForeColor = System.Drawing.Color.Blue;
            this.radblue.Location = new System.Drawing.Point(23, 135);
            this.radblue.Name = "radblue";
            this.radblue.Size = new System.Drawing.Size(58, 21);
            this.radblue.TabIndex = 2;
            this.radblue.TabStop = true;
            this.radblue.Text = "Blue";
            this.radblue.UseVisualStyleBackColor = true;
            this.radblue.CheckedChanged += new System.EventHandler(this.radblue_CheckedChanged);
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.Location = new System.Drawing.Point(23, 185);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(65, 21);
            this.radblack.TabIndex = 3;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            this.radblack.CheckedChanged += new System.EventHandler(this.radblack_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.ckbunderLine);
            this.groupBox2.Controls.Add(this.ckbitalic);
            this.groupBox2.Controls.Add(this.ckbbold);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(316, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 233);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // ckbbold
            // 
            this.ckbbold.AutoSize = true;
            this.ckbbold.ForeColor = System.Drawing.Color.Blue;
            this.ckbbold.Location = new System.Drawing.Point(19, 38);
            this.ckbbold.Name = "ckbbold";
            this.ckbbold.Size = new System.Drawing.Size(96, 21);
            this.ckbbold.TabIndex = 4;
            this.ckbbold.Text = "Đậm Bold";
            this.ckbbold.UseVisualStyleBackColor = true;
            this.ckbbold.CheckedChanged += new System.EventHandler(this.ckbbold_CheckedChanged);
            // 
            // ckbitalic
            // 
            this.ckbitalic.AutoSize = true;
            this.ckbitalic.ForeColor = System.Drawing.Color.Blue;
            this.ckbitalic.Location = new System.Drawing.Point(19, 100);
            this.ckbitalic.Name = "ckbitalic";
            this.ckbitalic.Size = new System.Drawing.Size(126, 21);
            this.ckbitalic.TabIndex = 5;
            this.ckbitalic.Text = "Nghiêng Italic";
            this.ckbitalic.UseVisualStyleBackColor = true;
            this.ckbitalic.CheckedChanged += new System.EventHandler(this.ckbitalic_CheckedChanged);
            // 
            // ckbunderLine
            // 
            this.ckbunderLine.AutoSize = true;
            this.ckbunderLine.ForeColor = System.Drawing.Color.Blue;
            this.ckbunderLine.Location = new System.Drawing.Point(19, 159);
            this.ckbunderLine.Name = "ckbunderLine";
            this.ckbunderLine.Size = new System.Drawing.Size(105, 21);
            this.ckbunderLine.TabIndex = 6;
            this.ckbunderLine.Text = "Gạch chân";
            this.ckbunderLine.UseVisualStyleBackColor = true;
            this.ckbunderLine.CheckedChanged += new System.EventHandler(this.ckbunderLine_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lập trình bởi:";
            // 
            // txtlaptrinh
            // 
            this.txtlaptrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlaptrinh.ForeColor = System.Drawing.Color.Red;
            this.txtlaptrinh.Location = new System.Drawing.Point(191, 391);
            this.txtlaptrinh.Multiline = true;
            this.txtlaptrinh.Name = "txtlaptrinh";
            this.txtlaptrinh.Size = new System.Drawing.Size(325, 28);
            this.txtlaptrinh.TabIndex = 6;
            this.txtlaptrinh.Text = "DE Thi 2023";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(188, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DE Thi 2023";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(453, 91);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDinhDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlaptrinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.label1);
            this.Name = "frmDinhDang";
            this.Text = "Định Dạng (Formater)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.RadioButton radblue;
        private System.Windows.Forms.RadioButton radgreen;
        private System.Windows.Forms.RadioButton radred;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbunderLine;
        private System.Windows.Forms.CheckBox ckbitalic;
        private System.Windows.Forms.CheckBox ckbbold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlaptrinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}