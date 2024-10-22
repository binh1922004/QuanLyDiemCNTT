using QuanLyDiemCNTT.dao;
using QuanLyDiemCNTT.entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDiemCNTT.view
{
    public partial class MenuChinh : Form
    {
        My_DB db = new My_DB();
        SinhVien sinhVien = new SinhVien();
        private Form activeForm;
        private DataGridView dgv;
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
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                string maSV = dgv.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();

                // Gọi một hàm khác để lấy điểm QT và KT của học phần này
                sinhVien.ShowDetailedScores(maSV, maHP);
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
            
            // Lấy thông tin sinh viên (giả định phương thức này trả về tất cả thông tin)
            var (mssv, ho, tenlot, ten, diaChi, queQuan, ngaySinh, email, isMale) = sinhVien.showInforSinhVien("SV001");

            // Kiểm tra nếu thông tin hợp lệ trước khi mở form
            if (mssv != null)
            {
                // Tạo form ThongTinSinhVien với dữ liệu đã lấy
                ThongTinSinhVien formThongTin = new ThongTinSinhVien(mssv, ho, tenlot, ten, diaChi, queQuan, ngaySinh, email, isMale);

                // Gọi hàm openChildForm để mở form trong pnl_Form
                openChildForm(formThongTin);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên!", "Thông báo");
            }
        }

        private void btn_xemDiem_Click(object sender, EventArgs e)
        {
            Form main = new Form();
            DataTable dt = sinhVien.showDiemSinhVien("SV001");

            openChildForm(main);

            initDataGridView();
            dgv.DataSource = dt;
            main.Controls.Add(dgv);
        }
    }
}
