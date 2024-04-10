using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiemHpQNU
{
    public partial class suaxoahp : Form
    {
        public suaxoahp()
        {
            InitializeComponent();
        }
        void chuanHoaData()
        {
            char format_demical = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            diemquatrinh_tb.Text = diemquatrinh_tb.Text.Replace('.', format_demical);
            diemck_tb.Text = diemck_tb.Text.Replace('.', format_demical);
            diemquatrinh_tb.Text = diemquatrinh_tb.Text.Replace(',', format_demical);
            diemck_tb.Text = diemck_tb.Text.Replace(',', format_demical);
        }
        private void suaxoahp_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            for (int i = 0; i < DiemHP.total_hp; i++)
            {
                hocphan_cb.Items.Add(DiemHP.list_hp[i].ToString());
            }
            DiemHP.is_ok = false;
            heso_combo.SelectedIndex = 1;
        }

        private void diemquatrinh_tb_Leave(object sender, EventArgs e)
        {
            chuanHoaData();
            try
            {
                if (float.Parse(diemquatrinh_tb.Text) < 0 || float.Parse(diemquatrinh_tb.Text) > 10)
                {
                    MessageBox.Show("Điểm quá trình không được nhỏ hơn 0 và lớn hơn 10");
                    diemquatrinh_tb.Text = "0";
                    diemquatrinh_tb.Select();
                }
            }
            catch
            {
                MessageBox.Show("Điểm quá trình nhập sai định dạng!");
                diemquatrinh_tb.Text = "0";
                diemquatrinh_tb.Select();
            }
        }

        private void diemck_tb_Leave(object sender, EventArgs e)
        {
            chuanHoaData();
            try
            {
                if (float.Parse(diemck_tb.Text) < 0 || float.Parse(diemck_tb.Text) > 10)
                {
                    MessageBox.Show("Điểm cuối kỳ không được nhỏ hơn 0 và lớn hơn 10");
                    diemck_tb.Text = "0";
                    diemck_tb.Select();
                }
            }
            catch
            {
                MessageBox.Show("Điểm cuối kỳ nhập sai định dạng!");
                diemck_tb.Text = "0";
                diemck_tb.Select();
            }
        }

        private void diemquatrinh_tb_Click(object sender, MouseEventArgs e)
        {
            if (diemquatrinh_tb.Text == "0")
                diemquatrinh_tb.Text = null;
        }

        private void diemck_tb_MouseClick(object sender, MouseEventArgs e)
        {
            if (diemck_tb.Text == "0")
                diemck_tb.Text = null;
        }

        private void sotc_numric_ValueChanged(object sender, EventArgs e)
        {
            if (sotc_numric.Value <= 0)
            {
                MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                sotc_numric.Value = 1;
            }
        }

        private void namehp_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sotc_numric.Select();
                //sotc_numric.Value = null;
            }
        }

        private void sotc_numric_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                diemquatrinh_tb.Select();

            }
        }

        private void diemquatrinh_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                diemck_tb.Select();
            }
        }

        private void diemck_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                heso_combo.Select();
            }
        }

        private void heso_combo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
        float precent_ck;
        private void button1_Click(object sender, EventArgs e)
        {
            DiemHP.modify_mode = 1;
            DiemHP.index_update = hocphan_cb.SelectedIndex;
            //MessageBox.Show(hocphan_cb.SelectedIndex.ToString());
            string namehp;
            int sotinchi;
            float diemQT;
            float diemCK;
            try
            {
                chuanHoaData();
                //namehp = namehp_tb.Text;
                sotinchi = (int)sotc_numric.Value;
                diemQT = float.Parse(diemquatrinh_tb.Text);
                diemCK = float.Parse(diemck_tb.Text);
                /*
                    5-5 (50% giữa kỳ, 50% cuối kỳ)
                    5-6 (40% giữa kỳ, 60% cuối kỳ)
                    3-7 (30% giữa kỳ, 70% cuối kỳ)
                */
                if (heso_combo.SelectedIndex == 0)
                {
                    precent_ck = 0.5F;
                }
                else if (heso_combo.SelectedIndex == 1) { precent_ck = 0.6F; }
                else if (heso_combo.SelectedIndex == 2) { precent_ck = 0.7F; }
                else if (heso_combo.SelectedIndex == 3) { precent_ck = 0.3F; }
                else if (heso_combo.SelectedIndex == 4) { precent_ck = 0.4F; }
                //DiemHP.namehp_input = namehp;
                DiemHP.sotinchi_input = sotinchi;
                DiemHP.diemQT_input = diemQT;
                DiemHP.diemCK_input = diemCK;
                DiemHP.precent_ck_input = precent_ck;
                DiemHP.is_ok = true;
                MessageBox.Show("Sửa thành công!");
            }
            catch
            {
                MessageBox.Show("Lỗi định dạng khi nhập dữ liệu!");
                DiemHP.is_ok = false;

            }
            //MessageBox.Show(diemquatrinh_tb.TextLength.ToString());
            if (DiemHP.is_ok)
                this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(hocphan_cb.SelectedIndex != -1)
            {
                DiemHP.is_ok = true;
                DiemHP.modify_mode = 2;
                DiemHP.index_update = hocphan_cb.SelectedIndex;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phần tử cần xoá");
            }

        }

        private void hocphan_cb_TextChanged(object sender, EventArgs e)
        {

        }

        private void hocphan_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hocphan_cb.SelectedIndex == -1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DiemHP.is_ok = true;
            DiemHP.modify_mode=3;
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    // BẢN QUYỀN THUỘC NGUYỄN KHÁNH DƯƠNG - 4651050044- NHÓM KLEENAHIDA[CNTT K46D]
    // SẢN PHẨM THAM GIA CUỘC THI PHẦN MỀM KHOA CÔNG NGHỆ THÔNG TIN TRƯỜNG ĐHQN
}
