using QuanLyDiemCNTT.dao;
using QuanLyDiemCNTT.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyDiemCNTT.entity
{
    internal class SinhVien
    {
        My_DB db = new My_DB();

            private string mssv;
            private string ho;
            private string tenLot;
            private string ten;
            private string diaChi;
            private string queQuan;
            private DateTime ngaySinh;
            private string email;
            private string gioiTinh;

        public string Mssv { get => mssv; set => mssv = value; }
        public string Ho { get => ho; set => ho = value; }
        public string TenLot { get => tenLot; set => tenLot = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Email { get => email; set => email = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public SinhVien(string mssv, string ho, string tenLot, string ten, string diaChi, string queQuan, DateTime ngaySinh, string email, string gioiTinh)
        {
            this.Mssv = mssv;
            this.Ho = ho;
            this.TenLot = tenLot;
            this.Ten = ten;
            this.DiaChi = diaChi;
            this.QueQuan = queQuan;
            this.NgaySinh = ngaySinh;
            this.Email = email;
            this.GioiTinh = gioiTinh;
        }

        public SinhVien()
        {

        }

        //    public (string, string , string, string, string, string, DateTime, string, bool) showInforSinhVien(string mssv)
        //    {
        //        string query = "SELECT MaSV, Ho, TenLot, Ten, DiaChi, QueQuan, NgaySinh, Email, GioiTinh " +
        //                        "FROM SinhVien WHERE MaSV = @mssv";

        //        db.openConnection();
        //        SqlCommand cmd = new SqlCommand(query, db.getConnection);
        //        cmd.Parameters.AddWithValue("@mssv", mssv);

        //        SqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            mssv = reader[0].ToString();
        //            string ho = reader[1].ToString();
        //            string tenLot = reader[2].ToString();
        //            string ten = reader[3].ToString();
        //            string diaChi = reader[4].ToString();
        //            string queQuan = reader[5].ToString();
        //            DateTime ngaySinh = reader["NgaySinh"] != DBNull.Value
        //? Convert.ToDateTime(reader["NgaySinh"])
        //: DateTime.Today;  // Giá trị mặc định nếu ngày sinh null
        //            string email = reader[7].ToString();
        //            string gioiTinh = reader[8].ToString();

        //        }
        //        bool isMale = (gioiTinh == "Nam") ? true : false;
        //        db.closeConnection();
        //        return(mssv, ho, tenLot, ten, diaChi, queQuan, ngaySinh, email, isMale);
        //    }

        public (string, string, string, string, string, string, DateTime, string, bool) showInforSinhVien(string mssv)
        {
            string query = "SELECT MaSV, Ho, TenLot, Ten, DiaChi, QueQuan, NgaySinh, Email, GioiTinh " +
                           "FROM SinhVien WHERE MaSV = @mssv";

            db.openConnection();
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.Parameters.AddWithValue("@mssv", mssv);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                mssv = reader["MaSV"].ToString();
                string ho = reader["Ho"].ToString();
                string tenLot = reader["TenLot"].ToString();
                string ten = reader["Ten"].ToString();
                string diaChi = reader["DiaChi"].ToString();
                string queQuan = reader["QueQuan"].ToString();
                DateTime ngaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                string email = reader["Email"].ToString();
                bool isMale = reader["GioiTinh"].ToString() == "Nam"; // Kiểm tra giới tính

                db.closeConnection();
                return (mssv, ho, tenLot, ten, diaChi, queQuan, ngaySinh, email, isMale);
            }

            db.closeConnection();
            return (null, null, null, null, null, null, DateTime.MinValue, null, false); // Trả về giá trị mặc định nếu không tìm thấy
        }


        // show điểm
        public DataTable showDiemSinhVien(string mssv)
        {
            string query = "SELECT " +
                "hp.HocKy, " +
                "hp.NamHoc, " +
                "hp.MaHP, " +
                "hp.TenHP, " +
                "AVG(bd.DiemQT + bd.DiemKT) / 2 AS DiemTB " +  // Tính điểm trung bình
                "FROM DangKy dk " +
                "JOIN HocPhan hp ON dk.MaHP = hp.MaHP " +
                "JOIN BangDiem bd ON dk.MaHP = bd.MaHP AND dk.MaSV = bd.MaSV " +
                "WHERE dk.MaSV = @mssv " +
                "GROUP BY hp.HocKy, hp.NamHoc, hp.MaHP, hp.TenHP"; 
            db.openConnection();
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.Parameters.AddWithValue("@mssv", mssv);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Thêm cột "Chi tiết"
            dt.Columns.Add("Chi tiết", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                row["Chi tiết"] = "Xem chi tiết";  // Thiết lập văn bản cho cột chi tiết
            }
            db.closeConnection();

            return dt;
        }

        // show điểm chi tiết(QT, KT)
        public void ShowDetailedScores(string maSV, string maHP)
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
                formChiTietDiem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy điểm chi tiết!", "Thông báo");
            }

            db.closeConnection();
        }

        // update thong tin sinh vien
        public bool updateInforSinhVien(SinhVien sv)
        {
            string query = "UPDATE SinhVien SET Ho = @ho, TenLot = @tenLot, Ten = @ten, " +
                        "DiaChi = @diaChi, QueQuan = @queQuan, NgaySinh = @ngaySinh, Email = @email, GioiTinh = @gioiTinh " +
                        "WHERE MaSV = @mssv";

            db.openConnection();
            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.Add("@mssv", SqlDbType.VarChar).Value = sv.Mssv;
            cmd.Parameters.Add("@ho", SqlDbType.NVarChar).Value = sv.Ho;
            cmd.Parameters.Add("@tenLot", SqlDbType.NVarChar).Value = sv.TenLot;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = sv.Ten;
            cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
            cmd.Parameters.Add("@queQuan", SqlDbType.NVarChar).Value = sv.QueQuan;
            cmd.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = sv.NgaySinh;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = sv.Email;
            cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;

            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
                
            
        }

    }
}
