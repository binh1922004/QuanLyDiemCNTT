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
        private void showDiemSinhVien()
        {
            string query = "SELECT " +
                "hp.HocKy, " +
                "hp.NamHoc, " +
                "hp.MaHP, " +
                "hp.TenHP, " +
                "AVG(bd.DiemQT + bd.DiemKT) / 2 AS DiemTB, " +  // Tính điểm trung bình
                "dk.MaSV " +  // Thêm MaSV để có thể sử dụng sau này
                "FROM DangKy dk " +
                "JOIN HocPhan hp ON dk.MaHP = hp.MaHP " +
                "JOIN BangDiem bd ON dk.MaHP = bd.MaHP AND dk.MaSV = bd.MaSV " +
                "WHERE dk.MaSV = 'SV001' " +
                "GROUP BY hp.HocKy, hp.NamHoc, hp.MaHP, hp.TenHP, dk.MaSV"; // Nhóm theo các cột không tính tổng
            db.openConnection();
            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Thêm cột "Chi tiết"
            dt.Columns.Add("Chi tiết", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                row["Chi tiết"] = "Xem chi tiết";  // Thiết lập văn bản cho cột chi tiết
            }

            

            dgv.DataSource = dt;

            // Đặt tên cột điểm TB
            //dgv.Columns["DiemTB"].HeaderText = "Điểm TB";

            // Ẩn các cột điểm QT và điểm KT
            // (Do chúng ta không lấy cột này trong truy vấn, nên không cần phải ẩn)

            // Thay đổi độ rộng của các cột để dễ nhìn hơn
            //dgv.Columns["DiemTB"].Width = 100;
            //dgv.Columns["Chi tiết"].Width = 100;

            db.closeConnection();
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
                ShowDetailedScores(maSV, maHP);
            }
            
        }

        private void ShowDetailedScores(string maSV, string maHP)
        {
            // truy vấn lấy điểm QT, KT và tên học phần
            string query = "SELECT hp.TenHP, bd.DiemQT, bd.DiemKT " +
                           "FROM BangDiem bd " +
                           "JOIN HocPhan hp ON bd.MaHP = hp.MaHP " +
                           "WHERE bd.MaSV = @MaSV AND bd.MaHP = @MaHP";

            db.openConnection();
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.Parameters.AddWithValue("@MaSV", maSV);
            cmd.Parameters.AddWithValue("@MaHP", maHP);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string tenHP = reader.GetString(0); // Lấy tên học phần
                double diemQT = reader.GetDouble(1); // Lấy điểm QT
                double diemKT = reader.GetDouble(2); // Lấy điểm KT

                // Tạo và hiển thị form chi tiết điểm với tên học phần
                ChiTietDiem formChiTietDiem = new ChiTietDiem(tenHP, diemQT, diemKT);
                formChiTietDiem.ShowDialog(); // Hiển thị dialog
            }
            else
            {
                MessageBox.Show("Không tìm thấy điểm chi tiết!", "Thông báo");
            }

            db.closeConnection();
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
