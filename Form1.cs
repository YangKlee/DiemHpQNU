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
using System.Runtime.Remoting.Messaging;

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
            bool ck_duoi5 = false;
            total_tc = 0;
            for (int i = 0; i < total_hp; i++)
            {
                if (float.Parse(point_table.Rows[i].Cells[3].Value.ToString()) <= 5)
                {
                    ck_duoi5 = true;
                }
                sum += float.Parse(point_table.Rows[i].Cells[4].Value.ToString()) * 
                    float.Parse(point_table.Rows[i].Cells[1].Value.ToString());
                sum4 += float.Parse(point_table.Rows[i].Cells[5].Value.ToString()) *
                    float.Parse(point_table.Rows[i].Cells[1].Value.ToString());
                //total_tc += int.Parse(point_table.Rows[i].Cells[1].Value.ToString());
                total_tc += int.Parse(point_table.Rows[i].Cells[1].Value.ToString());
            }
            int chisohocluc = 0;
            if (sum != 0 || total_tc != 0)
            {
                avg_hocky = sum / (float)total_tc;

            }
            else
            {
                avg_hocky = 0;
            }
            if (sum4 != 0 || total_tc != 0)
            {
                avg_hocky4 = sum4 / (float)total_tc;
            }
            else
            {
                avg_hocky4 = 0;
            }
            
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
                "Điểm TB học kỳ:(hệ 4): " + avg_hocky4.ToString("F2") + " \n" +
                "Điểm TB học kỳ:(hệ 10): " + avg_hocky.ToString("F2") + "\n" +
                "Xếp loại học lực: " + xlhocluc[chisohocluc];
            if(avg_hocky >= 7 &&  ck_duoi5 == false && total_tc >= 15 )
            {
                label1.Text += "\nBạn đủ điều kiện xét học bổng";
            }
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
            this.Controls.Clear();
            this.InitializeComponent();
            total_tc  = 0;
            total_hp = 0;

            config_ui();
            point_table.Rows.Clear();
            //point_table.Rows.Clear();

        }
        private void add_bt_Click(object sender, EventArgs e)
        {
            themhp themhp = new themhp();
            themhp.ShowDialog();
            if (is_ok)
            {
                //MessageBox.Show("Import dữ liệu thành công");
                point_table.Rows.Add(namehp_input, sotinchi_input, diemQT_input, diemCK_input,
                    TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input).ToString("F2"),
                    DoiDiem4(TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input)).ToString("F2"),
                    DoiDiemChu(TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input)), 
                    Check_Pass(TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input)));
                //total_tc += sotinchi_input;
                total_hp++;
                caluate_point();
            }
            else
            {
                MessageBox.Show("Đã huỷ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
            list_hp.Clear();
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
                    TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input).ToString("F2"),
                    DoiDiem4(TinhdiemHP(diemQT_input, diemCK_input, precent_ck_input)).ToString("F2"),
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
            else if(is_ok == true && modify_mode == 3)
            {
                MessageBox.Show("Đã huỷ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Lưu file lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Lưu file lỗi");
            //saveFileDialog1.DefaultExt = "txt";
            //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }
        public static List<string> hp_import = new List<string>();
        private void import_bt_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Tính năng này chưa được hoàn thiện!", "Cảnh báo!");

            //this.Close();
            DialogResult drg_repply = MessageBox.Show("Khi nhập file, toàn bộ dữ liệu đang nhập sẽ bị xoá!. " +
                "Bạn đồng ý chứ ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(drg_repply == DialogResult.Yes)
            {
                reset_all();
                openFileDialog1.Title = "Chọn file cần nhập:";
                openFileDialog1.Filter = "QNU files (*.QNU)|*.qnu";
                openFileDialog1.DefaultExt = "QNU";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    url_file = openFileDialog1.FileName;
                    try
                    {
                     
                        StreamReader getnum = new StreamReader(url_file);
                        int num = int.Parse(getnum.ReadLine()); // dong dau tien la so ban ghi
                        getnum.Close();
                        for(int i = 0; i < num; i++)
                        {
                            point_table.Rows.Add(null, null, null, null, null, null, null);
                        }
                        for(int j = 0; j < 8; j++)
                        {
                            hp_import.Clear();
                            StreamReader sr = new StreamReader(url_file);
                            sr.ReadLine();
                            while (!sr.EndOfStream)
                            {
                                    var line = sr.ReadLine();
                                    var values = line.Split(';');
                                    hp_import.Add(values[j]);
                                    //MessageBox.Show(values[j]);
                            }
                            //MessageBox.Show(j.ToString());
                            for(int i = 0; i < num; i++)
                            {
                                point_table.Rows[i].Cells[j].Value  = hp_import[i];
                            }
                            sr.Close();
                            total_hp = num;
  
                        }
                        config_ui();
                        caluate_point();
                    }
                    catch
                    {
                        MessageBox.Show("Đọc file lỗi, vui lòng xem file đúng định dạng hay chưa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reset_all();
                    }

                }
                else
                {
                    MessageBox.Show("Đã huỷ đọc file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            gioithieusanpham gioithieu = new gioithieusanpham();
            gioithieu.Show();
        }
    }
    // BẢN QUYỀN THUỘC NGUYỄN KHÁNH DƯƠNG - 4651050044- NHÓM KLEENAHIDA[CNTT K46D]
    // SẢN PHẨM THAM GIA CUỘC THI PHẦN MỀM KHOA CÔNG NGHỆ THÔNG TIN TRƯỜNG ĐHQN
}
