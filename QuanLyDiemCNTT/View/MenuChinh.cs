using QuanLyDiemCNTT.dao;
using QuanLyDiemCNTT.entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDiemCNTT.view
{
    public partial class MenuChinh : Form
    {
        My_DB db = new My_DB();

        // lấy tất cả các hàm trong class sinh viên
        SinhVien sinhVien = new SinhVien();

        private Form activeForm;
        private DataGridView dgv;

        string MaSV = "SV003";
        public MenuChinh()
        {
            InitializeComponent();
            initDataGridView();      
        }

        // Khởi tạo và cấu hình DataGridView
        private void initDataGridView()
        {
            dgv = new DataGridView(); // Khởi tạo DataGridView mỗi lần
            dgv.Dock = DockStyle.Fill;

            // tắt cột đầu
            dgv.RowHeadersVisible = false;

            // tắt dòng cuối
            dgv.AllowUserToAddRows = false;

            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Không cho phép người dùng điều chỉnh độ rộng các cột
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.Resizable = DataGridViewTriState.False;
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
            // Gán sự kiện CellClick ở đây
            dgv.CellClick += dgv_CellClick;
        }
        

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào cột "Chi tiết" không
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv.Columns["Chi tiết"].Index)
            {
                // Lấy mã học phần từ dòng đã nhấp
                string maHP = dgv.Rows[e.RowIndex].Cells["MaHP"].Value.ToString();

                // Gọi hàm để lấy điểm QT và KT của học phần này
                DataTable dt =  sinhVien.getChiTietDiem(MaSV, maHP);

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

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Form.Controls.Add(childForm);
            pnl_Form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_xemThongTin_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinSinhVien());
           
        }

        private void btn_xemDiem_Click(object sender, EventArgs e)
        {
            

            openChildForm(new BangDiemSV());

            
        }

        private void btn_dangKyMH_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhSachDKMH());
        }

        private void btn_showDSDKYHP_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhSachHPDaDKy());
        }
    }
}
