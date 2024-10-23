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
        public ThongTinSinhVien()
        {
            SinhVien sinhVien = new SinhVien();
            string maSV = "SV001";

            InitializeComponent();

            DataTable dt = sinhVien.getInforSinhVien(maSV);

            // Gán dữ liệu vào các control
            txt_mssv.Text = dt.Rows[0]["MaSV"].ToString();
            txt_ho.Text = dt.Rows[0]["Ho"].ToString();
            txt_tenLot.Text = dt.Rows[0]["TenLot"].ToString();
            txt_ten.Text = dt.Rows[0]["Ten"].ToString();
            txt_diaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            txt_queQuan.Text = dt.Rows[0]["QueQuan"].ToString();

            dtpk_ngaySinh.Value = Convert.ToDateTime(dt.Rows[0]["NgaySinh"]);

            txt_email.Text = dt.Rows[0]["Email"].ToString();

            string gioiTinh = dt.Rows[0]["GioiTinh"].ToString();
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
