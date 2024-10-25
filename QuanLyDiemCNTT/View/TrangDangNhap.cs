using QuanLyDiemCNTT.entity;
using QuanLyDiemCNTT.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemCNTT.view
{
    public partial class TrangDangNhap : Form
    {
        public TrangDangNhap()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            NguoiDung nguoiDung = new NguoiDung();
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (nguoiDung.KiemTraQuyenTruyCap(username, password))
            {
                string role = nguoiDung.LayPhanQuyen(username);

                if (role == "student" && rbtn_Student.Checked)
                {
                    MessageBox.Show("Sinh viên đăng nhập thành công!");
                    Global.id = username;
                    OpenMenuChinh();
                }
                else if (role == "teacher" && rbtn_Teacher.Checked)
                {
                    MessageBox.Show("Giảng viên đăng nhập thành công!");
                    OpenMenuGV();
                }
                else if (role == "admin" && rbtn_Admin.Checked)
                {
                    MessageBox.Show("Admin đăng nhập thành công!");
                    OpenMenuAdmin();
                }
                else
                {
                    MessageBox.Show("Sai quyền truy cập. Vui lòng chọn đúng quyền!");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }
        private void OpenMenuChinh()
        {
            MenuChinh menuChinh = new MenuChinh();
            menuChinh.Show();
        }
        private void OpenMenuGV()
        {
            MenuGV menuGV = new MenuGV();
            menuGV.Show();
        }

        private void OpenMenuAdmin()
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
        }
    }
}