using QuanLyDiemCNTT.dao;
using QuanLyDiemCNTT.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemCNTT.view
{
    public partial class DanhSachHPDaDKy : Form
    {
        string maSV = "SV003";
        My_DB db = new My_DB();
        int semester;
        public DanhSachHPDaDKy()
        {
            InitializeComponent();
            cb_semster.SelectedIndex = 0;
            //Xóa dòng cuối dgv
            dgv_DSHP.AllowUserToAddRows = false;
            lb_DSHP.Text = lb_DSHP.Text +" của "+ maSV;
        }

        private void DanhSachHPDaDKy_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }
        public void RefreshDGV()
        {         
            try
            {
                dgv_DSHP.DataSource = null;            
                string query = "proc_getHPSVDKY";
                db.openConnection();
                SqlCommand cmd = new SqlCommand(query, db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                // Thêm các tham số cho stored procedure
                cmd.Parameters.AddWithValue("@HocKy", semester);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                apt.Fill(dt);
                dgv_DSHP.DataSource = dt;

                // Kiểm tra và reset lại dgv
                foreach (DataGridViewColumn column in dgv_DSHP.Columns)
                {
                    if (column.HeaderText == "Xóa")
                    {
                        dgv_DSHP.Columns.Remove(column);
                        break;
                    }
                }

                foreach (DataGridViewColumn column in dgv_DSHP.Columns)
                {
                    if (column.HeaderText == "Chỉnh sửa")
                    {
                        dgv_DSHP.Columns.Remove(column);
                        break;
                    }
                }

                // Thêm button xóa
                DataGridViewButtonColumn historyButtonColumn = new DataGridViewButtonColumn();
                historyButtonColumn.HeaderText = "Xóa";
                historyButtonColumn.Text = "Xóa";
                historyButtonColumn.UseColumnTextForButtonValue = true;
                dgv_DSHP.Columns.Add(historyButtonColumn);

                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.HeaderText = "Chỉnh sửa";
                editButtonColumn.Text = "Chỉnh sửa";
                editButtonColumn.UseColumnTextForButtonValue = true;
                dgv_DSHP.Columns.Add(editButtonColumn);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void cb_semster_SelectedIndexChanged(object sender, EventArgs e)
        {
            int semesterIndex = cb_semster.SelectedIndex + 1;
            if (semesterIndex > 0) 
            {
                //MessageBox.Show("HK " + semesterIndex, "HK", MessageBoxButtons.OK);
                semester = semesterIndex;
                RefreshDGV();
            }
        }

        private void dgv_DSHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = dgv_DSHP.Columns[e.ColumnIndex];
                if (column.HeaderText == "Xóa")
                {
                    //Thực hiện lấy mã HP
                    string maHP = dgv_DSHP.Rows[e.RowIndex].Cells["Mã HP"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa học phần này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //MessageBox.Show(maHP);
                        DeleteHP(maHP);
                        RefreshDGV();
                    }
                }
                else if (column.HeaderText == "Chỉnh sửa")
                {
                    string maMH = dgv_DSHP.Rows[e.RowIndex].Cells["Mã Môn"].Value.ToString();
                    DanhSachDKHP danhSachDKHP = new DanhSachDKHP(maMH, semester);
                    danhSachDKHP.ShowDialog();
                    RefreshDGV();

                }
            }
        }

        public void DeleteHP(string mahp)
        {
            try
            {
                String query = "proc_deleteDangKy";
                db.openConnection();
                SqlCommand cmd = new SqlCommand(query,db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHP", mahp);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
