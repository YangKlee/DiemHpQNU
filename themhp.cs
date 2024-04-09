using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiemHpQNU
{
    public partial class themhp : Form
    {
        public themhp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void chuanHoaData()
        {
            char format_demical = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            diemquatrinh_tb.Text = diemquatrinh_tb.Text.Replace('.', format_demical);
            diemck_tb.Text = diemck_tb.Text.Replace('.', format_demical);
            diemquatrinh_tb.Text = diemquatrinh_tb.Text.Replace(',', format_demical);
            diemck_tb.Text = diemck_tb.Text.Replace(',', format_demical);
        }
        float precent_ck;
        private void button1_Click(object sender, EventArgs e)
        {
            string namehp;
            int sotinchi;
            float diemQT;
            float diemCK;
            try
            {
                chuanHoaData();
                namehp = namehp_tb.Text;
                sotinchi = (int)sotc_numric.Value;
                //MessageBox.Show(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
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

                DiemHP.namehp_input = namehp;
                DiemHP.sotinchi_input = sotinchi;
                DiemHP.diemQT_input = diemQT;
                DiemHP.diemCK_input = diemCK;
                DiemHP.precent_ck_input = precent_ck;
                if (namehp_tb.Text != "")
                {
                    DiemHP.is_ok = true;
                   
                }
                else
                    MessageBox.Show("Tên học phần không được để trống");
            }
            catch 
            {
                MessageBox.Show("Lỗi định dạng khi nhập dữ liệu!");
                DiemHP.is_ok = false;

            }
            //MessageBox.Show(diemquatrinh_tb.TextLength.ToString());
            if (DiemHP.is_ok)
            {
                this.Close();
            }
        }

        private void themhp_Load(object sender, EventArgs e)
        {
            DiemHP.is_ok = false;
            namehp_tb.Select();
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
            if(sotc_numric.Value <= 0)
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

        private void heso_combo_Leave(object sender, EventArgs e)
        {
           
        }

        private void namehp_tb_Leave(object sender, EventArgs e)
        {
            if (namehp_tb.Text == "")
            {
                MessageBox.Show("Tên học phần không được bỏ trống");
                DiemHP.is_ok = false;
            }
                


        }
    }
    // BẢN QUYỀN THUỘC NGUYỄN KHÁNH DƯƠNG - 4651050044- NHÓM KLEENAHIDA[CNTT K46D]
    // SẢN PHẨM THAM GIA CUỘC THI PHẦN MỀM KHOA CÔNG NGHỆ THÔNG TIN TRƯỜNG ĐHQN
}
