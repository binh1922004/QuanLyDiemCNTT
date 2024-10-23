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
    public partial class ThongTinGiangVien : Form
    {
        public ThongTinGiangVien()
        {
            InitializeComponent();
        }


        GiangVien giangVien = new GiangVien();
        private void ThongTinGiangVien_Load(object sender, EventArgs e)
        {
            DataTable dt = giangVien.getInfo("GV001");
            if (dt.Rows.Count > 0)
            {

                txt_maGV.Text = dt.Rows[0]["MaGV"].ToString();
                txt_ho.Text = dt.Rows[0]["Ho"].ToString();
                txt_tenLot.Text = dt.Rows[0]["TenLot"].ToString();
                txt_ten.Text = dt.Rows[0]["Ten"].ToString();
                txt_email.Text = dt.Rows[0]["Email"].ToString();

                dtpk_ngaySinh.Value = (DateTime)dt.Rows[0]["NgaySinh"];
            }
        }
    }
}
