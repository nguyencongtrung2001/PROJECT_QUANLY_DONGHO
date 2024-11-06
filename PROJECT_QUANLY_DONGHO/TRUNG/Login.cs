using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PROJECT_QUANLY_DONGHO.TRUNG
{
    public partial class Login : Form
    {    
        public Login()
        {
            InitializeComponent();    
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged; // Bắt sự kiện cho checkbox
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBox1.Text.Trim();
            string matKhau = textBox2.Text.Trim();

            if (KiemTraDangNhap(taiKhoan, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Chuyển sang giao diện chính hoặc thực hiện thao tác tiếp theo
                Home home = new Home();
                home.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại.");
            }


        }
        private bool KiemTraDangNhap(string taiKhoanNhap, string matKhauNhap)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("E:\\CUOIKY\\PROJECT_QUANLY_DONGHO\\PROJECT_QUANLY_DONGHO\\TRUNG\\XML\\Account.xml");

                // Tìm tất cả các phần tử "TaiKhoan"
                XmlNodeList taiKhoanNodes = xmlDoc.SelectNodes("TaiKhoanList/TaiKhoan");

                foreach (XmlNode node in taiKhoanNodes)
                {
                    // Đọc giá trị của tài khoản và mật khẩu từ từng node
                    string taiKhoan = node["Taikhoan"]?.InnerText;
                    string matKhau = node["MatKhau"]?.InnerText;

                    // So sánh tài khoản và mật khẩu nhập vào với dữ liệu trong XML
                    if (taiKhoan == taiKhoanNhap && matKhau == matKhauNhap)
                    {
                        return true; // Đăng nhập thành công
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file Account.xml: " + ex.Message);
            }

            return false; // Đăng nhập thất bại
        }



        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái của checkbox để hiển thị hoặc ẩn mật khẩu
            if (chkShowPassword.Checked)
            {
                textBox2.UseSystemPasswordChar = false; // Hiển thị mật khẩu
            }
            else
            {
                textBox2.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true; // Đặt ẩn mật khẩu ban đầu
        }
    }
}
