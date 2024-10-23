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
    public partial class DanhSachDKHP : Form
    {
        public DanhSachDKHP()
        {
            InitializeComponent();
        }

        string maMon;
        SinhVien sinhVien = new SinhVien();

        public DanhSachDKHP(string maMon)
        {
            this.maMon = maMon;
            InitializeComponent();
            loadData();
        }

        bool haveReg = false;
        string oldmaHP;
        void loadData()
        {
            try
            {
                dgv_DSHP.DataSource = sinhVien.getDSHocPhan(maMon, 1);

                dgv_DSHP.Columns["SoLuongConLai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                string maSV = "SV003";
                for (int i = 0; i < dgv_DSHP.Rows.Count - 1; i++)
                {
                    string maHP = dgv_DSHP.Rows[i].Cells[0].Value.ToString();
                    if (sinhVien.checkDaDangKy(maHP, maSV))
                    {
                        haveReg = true;
                        oldmaHP = maHP;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgv_DSHP.SelectedRows.Count > 0)
                {
                    var row = dgv_DSHP.SelectedRows[0];
                    string maHP = row.Cells[0].Value.ToString();
                    string maSV = "SV003";
                    if (haveReg)
                    {
                        sinhVien.doiHP(oldmaHP, maHP, maSV);
                    }
                    else
                    {
                        sinhVien.dangKyHP(maHP, maSV);
                    }
                    oldmaHP = maHP;
                    haveReg = true;

                    MessageBox.Show("Dang ky thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
