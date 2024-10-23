using QuanLyDiemCNTT.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemCNTT.view
{
    public partial class DanhSachMonFromGV : Form
    {
        public DanhSachMonFromGV()
        {
            InitializeComponent();
        }
        GiangVien giangVien = new GiangVien();
        private void DanhSachMonFromGV_Load(object sender, EventArgs e)
        {
            dgv_hk1.DataSource = giangVien.getDSMon("GV001", 1);
            dgv_hk2.DataSource = giangVien.getDSMon("GV001", 2);
        
       
        }

    }
}
