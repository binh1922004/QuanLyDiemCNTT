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
    public partial class BangDiemSV : Form
    {
        string MaSV = "SV001";
        SinhVien sinhVien = new SinhVien();
        public BangDiemSV()
        {
            InitializeComponent();

            dgv_hk1.DataSource = sinhVien.getDiemSinhVien(MaSV, 1);
            dgv_hk2.DataSource = sinhVien.getDiemSinhVien(MaSV, 2);
        }

        private void dgv_hk1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào cột "Chi tiết" không
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_hk1.Columns["Chi tiết"].Index)
            {
                // Lấy mã học phần từ dòng đã nhấp
                string maHP = dgv_hk1.Rows[e.RowIndex].Cells["MaHP"].Value.ToString();

                // Gọi hàm để lấy điểm QT và KT của học phần này
                DataTable dt = sinhVien.getChiTietDiem(MaSV, maHP);

                string tenHP = dt.Rows[0]["TenHP"].ToString();
                double diemQT = Convert.ToDouble(dt.Rows[0]["DiemQT"]);
                double diemKT = Convert.ToDouble(dt.Rows[0]["DiemKT"]);


                // kiem tra thong tin truoc khi mở form
                if (MaSV != null)
                {
                    ChiTietDiem chiTietDiem = new ChiTietDiem(tenHP, diemQT, diemKT);
                    chiTietDiem.ShowDialog();
                }
            }
        }

        private void dgv_hk2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào cột "Chi tiết" không
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_hk1.Columns["Chi tiết"].Index)
            {
                // Lấy mã học phần từ dòng đã nhấp
                string maHP = dgv_hk1.Rows[e.RowIndex].Cells["MaHP"].Value.ToString();

                // Gọi hàm để lấy điểm QT và KT của học phần này
                DataTable dt = sinhVien.getChiTietDiem(MaSV, maHP);

                string tenHP = dt.Rows[0]["TenHP"].ToString();
                double diemQT = Convert.ToDouble(dt.Rows[0]["DiemQT"]);
                double diemKT = Convert.ToDouble(dt.Rows[0]["DiemKT"]);


                // kiem tra thong tin truoc khi mở form
                if (MaSV != null)
                {
                    ChiTietDiem chiTietDiem = new ChiTietDiem(tenHP, diemQT, diemKT);
                    chiTietDiem.ShowDialog();
                }
            }
        }
    }
}
