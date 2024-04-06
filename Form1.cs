using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace DiemHpQNU
{
    public partial class DiemHP : Form
    {
        int total_tc = 0;
        public static int total_hp = 0;
        int total_tc_fail = 0;
        float avg_point = 0;
        string[] xlhocluc = { "Kém" , "Yếu", "Trung bình", "Khá", "Giỏi", "Xuất xắc"};
        public DiemHP()
        {
            InitializeComponent();
        }
        void caluate_point()
        {
            float avg_hocky = 0;
            float sum = 0;
            float avg_hocky4 = 0;
            float sum4 = 0;

            total_tc = 0;
            for (int i = 0; i < total_hp; i++)
            {
                
                sum += float.Parse(point_table.Rows[i].Cells[4].Value.ToString()) * 
                    float.Parse(point_table.Rows[i].Cells[1].Value.ToString());
                sum4 += float.Parse(point_table.Rows[i].Cells[5].Value.ToString()) *
                    float.Parse(point_table.Rows[i].Cells[1].Value.ToString());
                //total_tc += int.Parse(point_table.Rows[i].Cells[1].Value.ToString());
                total_tc += int.Parse(point_table.Rows[i].Cells[1].Value.ToString());
            }
            int chisohocluc = 0;

            avg_hocky = sum /(float) total_tc;
            avg_hocky4 = sum4 / (float)total_tc;
            if (avg_hocky4 >= 3.6)
                chisohocluc = 5;
            else if(avg_hocky4 < 3.6 && avg_hocky4 >= 3.2)
                chisohocluc = 4;
            else if (avg_hocky4 < 3.2 && avg_hocky4 >= 2.5)
                chisohocluc = 3;
            else if (avg_hocky4 < 2.5 && avg_hocky4 >= 2.0)
                chisohocluc = 2;
            else if (avg_hocky4 < 2.0 && avg_hocky4 >= 1.0)
                chisohocluc = 1;
            else if (avg_hocky4 <1)
                chisohocluc = 0;
            label1.Text = "Tổng số TC: " + total_tc + '\n' +
                "Điểm TB học kỳ:(hệ 4): " + avg_hocky4 + " \n" +
                "Điểm TB học kỳ:(hệ 10): " + avg_hocky + "\n" +
                "Xếp loại học lực: " + xlhocluc[chisohocluc];
        }
        public static string namehp_input;
        public static int sotinchi_input;
        public static float diemQT_input;
        public static float diemCK_input;
        public static float precent_ck_input;
        public static bool is_ok = false;
        float TinhdiemHP(float QT, float CK, float HS)
        {
            return (QT*(1-HS) + CK*HS);
        }
       
        float DoiDiem4(float n)
        {
            
            if (n < 4)
                return 0;
            else if (n >= 4 && n < 5)
            {
                return 1.5F;
            }
            else if (n >= 5 && n < 6)
            {
                return 2F;
            }
            else if (n >= 6 && n < 7)
            {
                return 2.5F;
            }
            else if (n >= 7 && n < 8)
            {
                return 3F;
            }
            else if (n >= 8 && n < 9)
            {
                return 3.5F;
            }
            else if (n >= 9 && n <= 10)
            {
                return 4F;
            }
            return 0;
            
        }
        string DoiDiemChu(float n)
        {

            if (n < 4)
                return  "F";
            else if (n >= 4 && n < 5)
            {
                return "D";
            }
            else if (n >= 5 && n < 6)
            {
                return "C";
            }
            else if (n >= 6 && n < 7)
            {
                return "B";
            }
            else if (n >= 7 && n < 8)
            {
                return "B+";
            }
            else if (n >= 8 && n < 9)
            {
                return "A";
            }
            else if (n >= 9 && n <= 10)
            {
                return "A+";
            }
            return null;

        }
        bool Check_Pass(float Diem_HP)
        {
            if (Diem_HP <= 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void config_ui()
        {
            if (total_hp == 0)
            {
                modify_bt.Enabled = false;
                save_bt.Enabled = false;
            }
            else
            {
                modify_bt.Enabled = true;
                save_bt.Enabled = true;
            }
        }
        void reset_all()
        {
            //point_table.Rows.Clear();
            this.Controls.Clear();
            this.InitializeComponent();


        }
        private void add_bt_Click(object sender, EventArgs e)
        {
            themhp themhp = new themhp();
            themhp.ShowDialog();
            if (is_ok)
            {
                string trolltrollvn = namehp_input.ToLower();
                if (trolltrollvn.Contains("never gonna give you up") ||
                    trolltrollvn.Contains("nevergonnagiveyouup")
                    || trolltrollvn.Contains("ditmemay") || trolltrollvn.Contains("dm")
                    || trolltrollvn.Contains("gay"))

                {
                    System.Diagnostics.Process.Start("https://youtu.be/dQw4w9WgXcQ?si=u6vn7xP7niFK5WQ9");
                    MessageBox.Show("Bạn sẽ bị rick roll nếu nhập những cụm từ không hợp lệ!");
                }
                //MessageBox.Show("Import dữ liệu thành công");
                point_table.Rows.Add(namehp_input, sotinchi_input, diemQT_input, diemCK_input,
                    TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input),
                    DoiDiem4(TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input)),
                    DoiDiemChu(TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input)), 
                    Check_Pass(TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input)));
                //total_tc += sotinchi_input;
                total_hp++;
                caluate_point();
            }
            else
            {
                MessageBox.Show("Đã huỷ");
            }
            config_ui();

        }
        public static List<string> list_hp = new List<string>();
        public static int modify_mode;
        public static int index_update;
        /*
         code trang thai
         1 - sua
         2 - xoa
         0 - loi
         */
        private void modify_bt_Click(object sender, EventArgs e)
        {
            
            for(int i = 0; i < total_hp; i++)
            {
                list_hp.Add(point_table.Rows[i].Cells[0].Value.ToString());
                //list_hp[i] =            
            }
            suaxoahp suaxoahp = new suaxoahp();
            suaxoahp.ShowDialog();
            if(is_ok == true && modify_mode == 1 && index_update != -1)
            {
                point_table.Rows[index_update].SetValues(list_hp[index_update], sotinchi_input, diemQT_input, diemCK_input,
                    TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input),
                    DoiDiem4(TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input)),
                    DoiDiemChu(TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input)),
                    Check_Pass(TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input)));
                //total_tc += sotinchi_input-  total_tc ;
                caluate_point();
            }
            else if(is_ok==true && modify_mode == 2)
            {
                //total_tc -= int.Parse(point_table.Rows[index_update].Cells[1].Value.ToString());
                point_table.Rows.RemoveAt(index_update);
                total_hp--;
                caluate_point();

            }
            else
            {
                MessageBox.Show("Không nhận được tham số chỉ định");
            }
            config_ui();

        }

        private void DiemHP_Load(object sender, EventArgs e)
        {
            config_ui();
        }
        string url_file;
        private void save_bt_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Chọn vị trí lưu file";
            saveFileDialog1.Filter = "QNU files (*.QNU)|*.qnu";
            saveFileDialog1.DefaultExt = "QNU";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(saveFileDialog1.FileName);
                url_file = saveFileDialog1.FileName;
                try
                {
                    System.IO.File.WriteAllText(url_file, total_hp.ToString() + "\n");
                    for (int i = 0; i < total_hp; i++)
                    {
                        System.IO.File.AppendAllText(url_file,
                            point_table.Rows[i].Cells[0].Value.ToString() + ';' +
                            point_table.Rows[i].Cells[1].Value.ToString() + ';' +
                            point_table.Rows[i].Cells[2].Value.ToString() + ';' +
                            point_table.Rows[i].Cells[3].Value.ToString() + ';' +
                            point_table.Rows[i].Cells[4].Value.ToString() + ';' +
                            point_table.Rows[i].Cells[5].Value.ToString() + ';' +
                            point_table.Rows[i].Cells[6].Value.ToString() + ';' +
                            point_table.Rows[i].Cells[7].Value.ToString() + '\n');
                    }
                }
                catch
                {
                    MessageBox.Show("Lưu file lỗi");
                }
            }
            else
                MessageBox.Show("Lưu file lỗi");
      


            //saveFileDialog1.DefaultExt = "txt";
            //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void import_bt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này chưa được hoàn thiện!", "Cảnh báo!");
            //System.Diagnostics.Process.Start("https://youtu.be/dQw4w9WgXcQ?si=u6vn7xP7niFK5WQ9");
            //this.Close();
            DialogResult drg_repply = MessageBox.Show("Khi nhập file, toàn bộ dữ liệu đang nhập sẽ bị xoá!. " +
                "Bạn đồng ý chứ ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if(drg_repply == DialogResult.Yes)
            {
                reset_all();
                //System.Diagnostics.Process.Start("https://youtu.be/dQw4w9WgXcQ?si=u6vn7xP7niFK5WQ9");
                openFileDialog1.Title = "Chọn file cần nhập:";
                openFileDialog1.Filter = "QNU files (*.QNU)|*.qnu";
                openFileDialog1.DefaultExt = "QNU";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    url_file = openFileDialog1.FileName;
                    try
                    {
                        StreamReader sr = new StreamReader(url_file);
                        int num = int.Parse(sr.ReadLine()); // dong dau tien la so ban ghi
                        for (int i = 0; i < num; i++)
                        {
                            string lines = sr.ReadLine();
                        }
                        //MessageBox.Show(a);
                    }
                    catch
                    {
                        MessageBox.Show("File không đúng định dạng!");
                    }
                }
                else
                {
                    MessageBox.Show("Đọc file lỗi!");
                }

            }

        }
    }
}
