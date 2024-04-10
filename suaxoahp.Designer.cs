namespace DiemHpQNU
{
    partial class suaxoahp
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
            this.heso_combo = new System.Windows.Forms.ComboBox();
            this.sotc_numric = new System.Windows.Forms.NumericUpDown();
            this.diemck_tb = new System.Windows.Forms.TextBox();
            this.diemquatrinh_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hocphan_cb = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sotc_numric)).BeginInit();
            this.SuspendLayout();
            // 
            // heso_combo
            // 
            this.heso_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.heso_combo.FormattingEnabled = true;
            this.heso_combo.Items.AddRange(new object[] {
            "5-5 (50% giữa kỳ, 50% cuối kỳ)",
            "4-6 (40% giữa kỳ, 60% cuối kỳ)",
            "3-7 (30% giữa kỳ, 70% cuối kỳ)",
            "7-3 (70% giữa kỳ, 30% cuối kỳ)",
            "6-4 (60% giữa kỳ, 40% cuối kỳ)"});
            this.heso_combo.Location = new System.Drawing.Point(102, 162);
            this.heso_combo.Name = "heso_combo";
            this.heso_combo.Size = new System.Drawing.Size(255, 28);
            this.heso_combo.TabIndex = 15;
            this.heso_combo.Text = "(Vui lòng chọn hệ số ...)";
            this.heso_combo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.heso_combo_KeyDown);
            // 
            // sotc_numric
            // 
            this.sotc_numric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sotc_numric.Location = new System.Drawing.Point(146, 68);
            this.sotc_numric.Name = "sotc_numric";
            this.sotc_numric.Size = new System.Drawing.Size(116, 26);
            this.sotc_numric.TabIndex = 14;
            this.sotc_numric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sotc_numric.ValueChanged += new System.EventHandler(this.sotc_numric_ValueChanged);
            this.sotc_numric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sotc_numric_KeyDown);
            // 
            // diemck_tb
            // 
            this.diemck_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diemck_tb.Location = new System.Drawing.Point(373, 117);
            this.diemck_tb.Name = "diemck_tb";
            this.diemck_tb.Size = new System.Drawing.Size(108, 26);
            this.diemck_tb.TabIndex = 11;
            this.diemck_tb.Text = "0";
            this.diemck_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.diemck_tb_MouseClick);
            this.diemck_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.diemck_tb_KeyDown);
            this.diemck_tb.Leave += new System.EventHandler(this.diemck_tb_Leave);
            // 
            // diemquatrinh_tb
            // 
            this.diemquatrinh_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diemquatrinh_tb.Location = new System.Drawing.Point(178, 117);
            this.diemquatrinh_tb.Name = "diemquatrinh_tb";
            this.diemquatrinh_tb.Size = new System.Drawing.Size(108, 26);
            this.diemquatrinh_tb.TabIndex = 12;
            this.diemquatrinh_tb.Text = "0";
            this.diemquatrinh_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.diemquatrinh_tb_Click);
            this.diemquatrinh_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.diemquatrinh_tb_KeyDown);
            this.diemquatrinh_tb.Leave += new System.EventHandler(this.diemquatrinh_tb_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(303, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cuối kỳ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(98, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quá trình:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(27, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hệ số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Điểm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số tín chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Học phần:";
            // 
            // hocphan_cb
            // 
            this.hocphan_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hocphan_cb.FormattingEnabled = true;
            this.hocphan_cb.Location = new System.Drawing.Point(129, 24);
            this.hocphan_cb.Name = "hocphan_cb";
            this.hocphan_cb.Size = new System.Drawing.Size(267, 28);
            this.hocphan_cb.TabIndex = 18;
            this.hocphan_cb.Text = "(Chọn học phần cần sửa/xoá)";
            this.hocphan_cb.SelectedIndexChanged += new System.EventHandler(this.hocphan_cb_SelectedIndexChanged);
            this.hocphan_cb.TextChanged += new System.EventHandler(this.hocphan_cb_TextChanged);
            this.hocphan_cb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.namehp_tb_KeyDown);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Image = global::DiemHpQNU.Properties.Resources.cacel;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(531, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 59);
            this.button3.TabIndex = 16;
            this.button3.Text = "Huỷ bỏ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Image = global::DiemHpQNU.Properties.Resources.delete;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(531, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 58);
            this.button2.TabIndex = 16;
            this.button2.Text = "Xoá HP";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Image = global::DiemHpQNU.Properties.Resources.edit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(531, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 59);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sửa HP";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // suaxoahp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DiemHpQNU.Properties.Resources.istockphoto_1369372299_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 226);
            this.Controls.Add(this.hocphan_cb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.heso_combo);
            this.Controls.Add(this.sotc_numric);
            this.Controls.Add(this.diemck_tb);
            this.Controls.Add(this.diemquatrinh_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "suaxoahp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa / Xoá học phần";
            this.Load += new System.EventHandler(this.suaxoahp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sotc_numric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox heso_combo;
        private System.Windows.Forms.NumericUpDown sotc_numric;
        private System.Windows.Forms.TextBox diemck_tb;
        private System.Windows.Forms.TextBox diemquatrinh_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hocphan_cb;
        private System.Windows.Forms.Button button3;
    }
}