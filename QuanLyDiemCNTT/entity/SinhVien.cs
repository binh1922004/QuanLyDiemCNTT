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

        

        public DataTable getInforSinhVien(string mssv)
        {
            string query = "proc_showThongTinSV";

            db.openConnection();
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mssv", mssv);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            adapter.Fill(dt);

            db.closeConnection();
            return dt;
        }


        // show điểm
        public DataTable getDiemSinhVien(string mssv, int hocky)
        {
            string query = "proc_showDiemSV"; 
            db.openConnection();
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mssv", mssv);
            cmd.Parameters.AddWithValue("@hocky", hocky);

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
        public DataTable getChiTietDiem(string maSV, string maHP)
        {
            // truy vấn lấy điểm QT, KT và tên học phần
            string query = "proc_showDiemChiTiet";

            db.openConnection();
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSV", maSV);
            cmd.Parameters.AddWithValue("@MaHP", maHP);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            db.closeConnection();
            return dt;
        }

        // update thong tin sinh vien
        public bool updateInforSinhVien(SinhVien sv)
        {
            string query = "proc_editThongTinSV";

            db.openConnection();
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.CommandType= CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = sv.Mssv;
            cmd.Parameters.Add("@Ho", SqlDbType.NVarChar).Value = sv.Ho;
            cmd.Parameters.Add("@TenLot", SqlDbType.NVarChar).Value = sv.TenLot;
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = sv.Ten;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
            cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = sv.QueQuan;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = sv.NgaySinh.Date;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = sv.Email;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;

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

        public DataTable getDanhSachDKMH()
        {
            string query = "proc_getListDKMH";

            db.openConnection();

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            db.closeConnection();

            return dt;

        }

        public DataTable getMonHoc()
        {
            string query = "proc_getMH";

            db.openConnection();

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            db.closeConnection();

            return dt;
        }

        public DataTable getMonHocSVChuaDKy(string MS)
        {
            string query = "proc_getMHSVChuaDangKy";
            

            db.openConnection();

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSV", MS);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            db.closeConnection();

            return dt;
        }

        public DataTable getDSHocPhan(string maMH, int hocKy = 2)
        {
            string query = "proc_getHP";

            db.openConnection();

            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaMH", SqlDbType.VarChar).Value = maMH;
            cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = hocKy;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            db.closeConnection();

            return dt;
        }

        public bool checkDaDangKy(string maHP, string maSV)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("SELECT dbo.CheckDangKy(@MaHP, @MaSV)", db.getConnection);
            command.Parameters.AddWithValue("@MaHP", maHP);
            command.Parameters.AddWithValue("@MaSV", maSV);
            bool result = (bool)command.ExecuteScalar();
            db.closeConnection();
            return result;
        }


        public void dangKyHP(string maHP, string maSV)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("proc_insertDangKy", db.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = maHP;
            command.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV;

            command.ExecuteNonQuery();
            db.closeConnection();
        }

        public void doiHP(string oldMaHP, string newMaHP, string maSV)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("proc_updateDangKy", db.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@NewMaHP", newMaHP);
            command.Parameters.AddWithValue("@OldMaHP", oldMaHP);
            command.Parameters.AddWithValue("@MaSV", maSV);

            command.ExecuteNonQuery();
            db.closeConnection();
        }


    }
}
