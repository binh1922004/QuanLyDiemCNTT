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
    public partial class DanhSachDKMH : Form
    {
        SinhVien sinhVien = new SinhVien();
        public DanhSachDKMH()
        {
            InitializeComponent();

            loadData();
            
        }

        void loadData()
        {
            DataTable dt = sinhVien.getDanhSachDKMH();

            dgv_listDKMH.DataSource = dt;
        }
        
    }
}
