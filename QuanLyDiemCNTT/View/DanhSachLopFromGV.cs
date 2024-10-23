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
    public partial class DanhSachLopFromGV : Form
    {
        public DanhSachLopFromGV()
        {
            InitializeComponent();
        }

        private string maMon;
        private string tenMon;
        private int hocKy;

        GiangVien giangVien = new GiangVien();
        public DanhSachLopFromGV(string maMon, string tenMon, int hocKy)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
            this.hocKy = hocKy;


            InitializeComponent();

            lbl_MaMon.Text += maMon;
            lbl_TenMon.Text += tenMon;

            loadData();
        }

        private void loadData()
        {
            dgv_lop.DataSource = giangVien.getDSLop(maMon, "GV001", hocKy);
            dgv_lop.Columns[dgv_lop.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
