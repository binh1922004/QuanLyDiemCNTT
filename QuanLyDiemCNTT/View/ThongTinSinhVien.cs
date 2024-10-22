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
    public partial class ThongTinSinhVien : Form
    {
        public ThongTinSinhVien(string mssv, string ho, string tenLot, string ten, string diaChi, string queQuan, DateTime ngaySinh, string email, bool isMale)
        {
            InitializeComponent();

            // Gán dữ liệu vào các control
            txt_mssv.Text = mssv;
            txt_ho.Text = ho;
            txt_tenLot.Text = tenLot;
            txt_ten.Text = ten;
            txt_diaChi.Text = diaChi;
            txt_queQuan.Text = queQuan;
            if (ngaySinh >= dtpk_ngaySinh.MinDate && ngaySinh <= dtpk_ngaySinh.MaxDate)
            {
                dtpk_ngaySinh.Value = ngaySinh.Date;  // Chỉ lấy phần ngày, bỏ qua thời gian
            }
            else
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi");
                dtpk_ngaySinh.Value = DateTime.Today;  // Gán giá trị mặc định nếu lỗi
            }
            txt_email.Text = email;

            // Gán trạng thái cho RadioButton
            if (isMale)
                rad_nam.Checked = true;
            else
                rad_nu.Checked = true;
        }

    }
}
