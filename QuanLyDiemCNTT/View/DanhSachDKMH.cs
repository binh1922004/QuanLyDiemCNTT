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
        string MaSV;
        public DanhSachDKMH()
        {
            InitializeComponent();
            MaSV = Global.id;
            loadData();
        }

        void loadData()
        {
            DataTable dt = sinhVien.getMonHocSVChuaDKy(MaSV);

            dgv_listDKMH.DataSource = dt;

            dgv_listDKMH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgv_listDKMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0)
                return;
            string maMon = dgv_listDKMH.Rows[index].Cells["MaMon"].Value.ToString();
            DanhSachDKHP danhSachDKHP = new DanhSachDKHP(maMon);
            danhSachDKHP.ShowDialog();
        }

        private void timer_reload_Tick(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
