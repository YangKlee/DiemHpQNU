namespace DiemHpQNU
{
    partial class DiemHP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiemHP));
            this.lb1 = new System.Windows.Forms.Label();
            this.point_table = new System.Windows.Forms.DataGridView();
            this.NameHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemHK4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemHKChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetQua = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.import_bt = new System.Windows.Forms.Button();
            this.save_bt = new System.Windows.Forms.Button();
            this.modify_bt = new System.Windows.Forms.Button();
            this.add_bt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.point_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb1.ForeColor = System.Drawing.Color.Red;
            this.lb1.Location = new System.Drawing.Point(1, 108);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(938, 46);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Phần mềm tính điểm học phần";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // point_table
            // 
            this.point_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.point_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.point_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameHP,
            this.SoTC,
            this.DiemQT,
            this.DiemCK,
            this.DiemTK,
            this.DiemHK4,
            this.DiemHKChu,
            this.KetQua});
            this.point_table.Location = new System.Drawing.Point(16, 157);
            this.point_table.Name = "point_table";
            this.point_table.Size = new System.Drawing.Size(746, 320);
            this.point_table.TabIndex = 2;
            // 
            // NameHP
            // 
            this.NameHP.Frozen = true;
            this.NameHP.HeaderText = "Tên học phần";
            this.NameHP.Name = "NameHP";
            this.NameHP.ReadOnly = true;
            this.NameHP.Width = 200;
            // 
            // SoTC
            // 
            this.SoTC.Frozen = true;
            this.SoTC.HeaderText = "Số tín chỉ";
            this.SoTC.Name = "SoTC";
            this.SoTC.ReadOnly = true;
            this.SoTC.Width = 80;
            // 
            // DiemQT
            // 
            this.DiemQT.Frozen = true;
            this.DiemQT.HeaderText = "Điểm QT";
            this.DiemQT.Name = "DiemQT";
            this.DiemQT.ReadOnly = true;
            this.DiemQT.Width = 80;
            // 
            // DiemCK
            // 
            this.DiemCK.Frozen = true;
            this.DiemCK.HeaderText = "Điểm CK";
            this.DiemCK.Name = "DiemCK";
            this.DiemCK.ReadOnly = true;
            this.DiemCK.Width = 80;
            // 
            // DiemTK
            // 
            this.DiemTK.Frozen = true;
            this.DiemTK.HeaderText = "Điểm HP";
            this.DiemTK.Name = "DiemTK";
            this.DiemTK.ReadOnly = true;
            this.DiemTK.Width = 80;
            // 
            // DiemHK4
            // 
            this.DiemHK4.Frozen = true;
            this.DiemHK4.HeaderText = "Điểm HP(Hệ 4)";
            this.DiemHK4.Name = "DiemHK4";
            this.DiemHK4.Width = 80;
            // 
            // DiemHKChu
            // 
            this.DiemHKChu.HeaderText = "Điểm chữ";
            this.DiemHKChu.Name = "DiemHKChu";
            this.DiemHKChu.ReadOnly = true;
            this.DiemHKChu.Width = 50;
            // 
            // KetQua
            // 
            this.KetQua.HeaderText = "Kết quả";
            this.KetQua.Name = "KetQua";
            this.KetQua.ReadOnly = true;
            this.KetQua.Width = 50;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(16, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 99);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng số TC: 0\r\nĐiểm TB học kỳ (hệ 4): 0\r\nĐiểm TB học kỳ (hệ 10): 0\r\nXếp loại học " +
    "lực: -";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(704, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "@YangKlee2024-Rel2.0<Build: 100420241500>";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // import_bt
            // 
            this.import_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.import_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.import_bt.Image = global::DiemHpQNU.Properties.Resources.save2;
            this.import_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.import_bt.Location = new System.Drawing.Point(781, 391);
            this.import_bt.Name = "import_bt";
            this.import_bt.Size = new System.Drawing.Size(137, 67);
            this.import_bt.TabIndex = 4;
            this.import_bt.Text = "Nhập điểm";
            this.import_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.import_bt.UseVisualStyleBackColor = true;
            this.import_bt.Click += new System.EventHandler(this.import_bt_Click);
            // 
            // save_bt
            // 
            this.save_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.save_bt.Image = global::DiemHpQNU.Properties.Resources.save;
            this.save_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_bt.Location = new System.Drawing.Point(781, 318);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(137, 67);
            this.save_bt.TabIndex = 4;
            this.save_bt.Text = "Lưu điểm";
            this.save_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_bt.UseVisualStyleBackColor = true;
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // modify_bt
            // 
            this.modify_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modify_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.modify_bt.Image = global::DiemHpQNU.Properties.Resources.edit;
            this.modify_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modify_bt.Location = new System.Drawing.Point(781, 245);
            this.modify_bt.Name = "modify_bt";
            this.modify_bt.Size = new System.Drawing.Size(137, 67);
            this.modify_bt.TabIndex = 4;
            this.modify_bt.Text = "Sửa, xoá";
            this.modify_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modify_bt.UseVisualStyleBackColor = true;
            this.modify_bt.Click += new System.EventHandler(this.modify_bt_Click);
            // 
            // add_bt
            // 
            this.add_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.add_bt.Image = global::DiemHpQNU.Properties.Resources.add3;
            this.add_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_bt.Location = new System.Drawing.Point(781, 172);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(137, 67);
            this.add_bt.TabIndex = 4;
            this.add_bt.Text = "Thêm HP";
            this.add_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(938, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DiemHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DiemHpQNU.Properties.Resources.pngtree_minimalistic_blue_honeycomb_technology_background_picture_image_1085284;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.import_bt);
            this.Controls.Add(this.save_bt);
            this.Controls.Add(this.modify_bt);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.point_table);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DiemHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm tính điểm học phần";
            this.Load += new System.EventHandler(this.DiemHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.point_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView point_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button modify_bt;
        private System.Windows.Forms.Button save_bt;
        private System.Windows.Forms.Button import_bt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemHK4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemHKChu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn KetQua;
    }
}

