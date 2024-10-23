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
    public partial class DanhSachSinhVienTheoLop : Form
    {
        public DanhSachSinhVienTheoLop()
        {
            InitializeComponent();
        }
        string maHP;
        GiangVien giangVien = new GiangVien();
        public DanhSachSinhVienTheoLop(string maHP)
        {
            InitializeComponent();
            this.maHP = maHP;
            lbl_lop.Text += maHP;

            loadData();
        }


        void loadData()
        {
            dgv_DSSV.DataSource = giangVien.getDiem(maHP);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dr in dgv_DSSV.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {

                        string maSV = dr.Cells[0].Value.ToString();
                        float diemQT = float.Parse(dr.Cells[1].Value.ToString());
                        float diemKT = float.Parse(dr.Cells[2].Value.ToString());

                        if (!giangVien.updateDiem(maHP, maSV, diemQT, diemKT))
                        {
                            MessageBox.Show("Error!");
                        }
                    }
                }

                MessageBox.Show("Cập nhật điểm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
