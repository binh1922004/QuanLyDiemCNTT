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
    public partial class MenuChucNang : Form
    {
        public MenuChucNang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuGV menuGV = new MenuGV();
            menuGV.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuChinh menuChinh = new MenuChinh(); 
            menuChinh.ShowDialog();
        }
    }
}
