using QuanLyDiemCNTT.dao;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDiemCNTT.entity
{
    internal class NguoiDung
    {
        My_DB myDB = new My_DB();
        private int id;
        private string tenDangNhap;
        private string matKhau;

        public int Id { get => id; set => id = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

        // Method to check if the username exists
        public bool KiemTraNguoiDungTonTai(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Tên đăng nhập không được để trống");
            }

            myDB.openConnection();
            SqlCommand sqlCmd = new SqlCommand("proc_KiemTraNguoiDungTonTai", myDB.getConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar)).Value = username;
            int count = (int)sqlCmd.ExecuteScalar();
            myDB.closeConnection();
            return count > 0;
        }

        // Method to validate the username and password
        public bool KiemTraQuyenTruyCap(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Tên đăng nhập và mật khẩu không được để trống");
            }

            myDB.openConnection();
            SqlCommand sqlCmd = new SqlCommand("proc_KiemTraQuyenTruyCap", myDB.getConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar)).Value = username;
            sqlCmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar)).Value = password;
            int count = (int)sqlCmd.ExecuteScalar();
            myDB.closeConnection();
            return count > 0;
        }

        // Method to get the role of the user
        public string LayPhanQuyen(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Tên đăng nhập không được để trống");
            }

            myDB.openConnection();
            SqlCommand sqlCmd = new SqlCommand("proc_LayPhanQuyen", myDB.getConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar)).Value = username;
            string roleName = (string)sqlCmd.ExecuteScalar();
            myDB.closeConnection();
            return roleName;
        }
    }
}