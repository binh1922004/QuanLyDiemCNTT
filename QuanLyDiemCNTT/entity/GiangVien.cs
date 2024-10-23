using QuanLyDiemCNTT.dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemCNTT.entity
{
    internal class GiangVien
    {
        My_DB db = new My_DB();


        public DataTable getInfo(String maGV)
        {
            db.openConnection();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.GetLecturerInfo(@MAGV)", db.getConnection);
            sqlCmd.Parameters.Add(new SqlParameter("@MAGV", SqlDbType.VarChar)).Value = maGV;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.closeConnection();
            return dt;
        }

        public DataTable getDSMon(String maGV, int hocKy)
        {
            db.openConnection();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.GetDistinctCoursesByLecturer(@MAGV, @HK)", db.getConnection);
            sqlCmd.Parameters.Add(new SqlParameter("@MAGV", SqlDbType.VarChar)).Value = maGV;
            sqlCmd.Parameters.Add(new SqlParameter("@HK", SqlDbType.Int)).Value = hocKy;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.closeConnection();

            return dt;
        }

        public DataTable getDSLop(String maMon, String maGV, int hocKy)
        {
            db.openConnection();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.GetHocPhanByHocKy(@MAMH, @MAGV, @HK)", db.getConnection);
            sqlCmd.Parameters.Add(new SqlParameter("@MAGV", SqlDbType.VarChar)).Value = maGV;
            sqlCmd.Parameters.Add(new SqlParameter("@MAMH", SqlDbType.VarChar)).Value = maMon;
            sqlCmd.Parameters.Add(new SqlParameter("@HK", SqlDbType.Int)).Value = hocKy;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.closeConnection();

            return dt;
        }


        public DataTable getDiem(String maHP)
        {
            db.openConnection();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.GetDiem(@MAHP)", db.getConnection);
            sqlCmd.Parameters.Add(new SqlParameter("@MAHP", SqlDbType.VarChar)).Value = maHP;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.closeConnection();
            return dt;
        }

        public bool updateDiem(string maHP, string maSV, float diemQT, float diemKT)
        {
            db.openConnection();
            SqlCommand sqlCmd = new SqlCommand("UpdateDiem", db.getConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = maHP;
            sqlCmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV;
            sqlCmd.Parameters.Add("@DiemQT", SqlDbType.Float).Value = diemQT;
            sqlCmd.Parameters.Add("@DiemKT", SqlDbType.Float).Value = diemKT;
            return sqlCmd.ExecuteNonQuery() > 0;
        }

        public bool updateThongTin(string maGV, string ho, string tenLot, string ten, DateTime ngaySinh, string email)
        {
            db.openConnection();
            SqlCommand sqlCmd = new SqlCommand("UpdateGiangVien", db.getConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.Add("@maGV", SqlDbType.VarChar).Value = maGV;
            sqlCmd.Parameters.Add("@ho", SqlDbType.VarChar).Value = ho;
            sqlCmd.Parameters.Add("@tenLot", SqlDbType.VarChar).Value = tenLot;
            sqlCmd.Parameters.Add("@ten", SqlDbType.VarChar).Value = ten;
            sqlCmd.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = ngaySinh;
            sqlCmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            return sqlCmd.ExecuteNonQuery() > 0;
        }
    }
}
