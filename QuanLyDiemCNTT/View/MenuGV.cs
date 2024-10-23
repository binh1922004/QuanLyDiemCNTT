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
    public partial class MenuGV : Form
    {
        public MenuGV()
        {
            InitializeComponent();
        }

        private Form activeForm;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Form.Controls.Add(childForm);
            pnl_Form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Info_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinGiangVien());

        }

        private void btn_MH_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhSachMonFromGV());
        }
    }
}
