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



        void openLopForm(string maMon, string tenMon, int hocKy)
        {
            DanhSachLopFromGV danhSachLopFromGV = new DanhSachLopFromGV(maMon, tenMon, hocKy);


            danhSachLopFromGV.ShowDialog();
        }

        private void dgv_hk1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                string maMon = dgv_hk1.Rows[index].Cells[0].Value.ToString();
                string tenMon = dgv_hk1.Rows[index].Cells[1].Value.ToString();
                openLopForm(maMon, tenMon, 1);
            }
        }

        private void dgv_hk2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                string maMon = dgv_hk2.Rows[index].Cells[0].Value.ToString();
                string tenMon = dgv_hk2.Rows[index].Cells[1].Value.ToString();
                openLopForm(maMon, tenMon, 2);
            }
        }
    }
}
