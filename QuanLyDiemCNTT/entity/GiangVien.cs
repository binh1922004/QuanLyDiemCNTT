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

        private string maGV;
        private string ho;
        private string tenLot;
        private string ten;
        private DateTime ngaySinh;
        private string email;
        private string maBM;

        public string MaGV { get => maGV; set => maGV = value; }
        public string Ho { get => ho; set => ho = value; }
        public string TenLot { get => tenLot; set => tenLot = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Email { get => email; set => email = value; }
        public string MaBM { get => maBM; set => maBM = value; }


        public DataTable getInfo(String maGV)
        {
            db.openConnection();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.GetLecturerInfo(@MAGV)", db.getConnection);
            sqlCmd.Parameters.Add(new SqlParameter("@MAGV", SqlDbType.VarChar)).Value = maGV;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            return dt;
        }
    }
}
