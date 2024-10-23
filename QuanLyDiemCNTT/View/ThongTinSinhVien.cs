using QuanLyDiemCNTT.entity;
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
        public ThongTinSinhVien(string mssv, string ho, string tenLot, string ten, string diaChi, string queQuan, DateTime ngaySinh, string email, string gioiTinh)
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
            if (gioiTinh.Equals("Nam"))
                rad_nam.Checked = true;
            else
                rad_nu.Checked = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Mssv = txt_mssv.Text;
            sv.Ho = txt_ho.Text;
            sv.TenLot = txt_tenLot.Text;
            sv.Ten = txt_ten.Text;
            sv.DiaChi = txt_diaChi.Text;
            sv.QueQuan = txt_queQuan.Text;
            sv.NgaySinh = dtpk_ngaySinh.Value.Date;
            sv.Email = txt_email.Text;
            if (rad_nam.Checked)
                sv.GioiTinh = "Nam";
            else
                sv.GioiTinh = "Nữ";
            if (sv.updateInforSinhVien(sv))
            {
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại", "Thông báo", MessageBoxButtons.OKCancel);
            }
        }
    }
}
