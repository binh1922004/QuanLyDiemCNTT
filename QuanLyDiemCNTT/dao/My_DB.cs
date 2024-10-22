using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemCNTT.dao
{
    internal class My_DB
    {
        SqlConnection conn = null;

        public My_DB() 
        {
            conn = new SqlConnection(@"Data Source=NHAATJNGUYEEN;Initial Catalog=QLDiemSVKhoaCNTT;Integrated Security=True");
        }

        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }
        
        public void openConnection()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
