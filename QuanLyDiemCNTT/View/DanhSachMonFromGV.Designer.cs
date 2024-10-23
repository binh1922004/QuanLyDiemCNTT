namespace QuanLyDiemCNTT.view
{
    partial class DanhSachMonFromGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.group_Hk1 = new System.Windows.Forms.GroupBox();
            this.group_Hk2 = new System.Windows.Forms.GroupBox();
            this.dgv_hk1 = new System.Windows.Forms.DataGridView();
            this.dgv_hk2 = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_Hk1.SuspendLayout();
            this.group_Hk2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hk2)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Hk1
            // 
            this.group_Hk1.Controls.Add(this.dgv_hk1);
            this.group_Hk1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_Hk1.Location = new System.Drawing.Point(0, 0);
            this.group_Hk1.Name = "group_Hk1";
            this.group_Hk1.Size = new System.Drawing.Size(560, 608);
            this.group_Hk1.TabIndex = 0;
            this.group_Hk1.TabStop = false;
            this.group_Hk1.Text = "Học kỳ 1";
            // 
            // group_Hk2
            // 
            this.group_Hk2.Controls.Add(this.dgv_hk2);
            this.group_Hk2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.group_Hk2.Location = new System.Drawing.Point(0, 293);
            this.group_Hk2.Name = "group_Hk2";
            this.group_Hk2.Size = new System.Drawing.Size(560, 315);
            this.group_Hk2.TabIndex = 1;
            this.group_Hk2.TabStop = false;
            this.group_Hk2.Text = "Học kỳ 2";
            // 
            // dgv_hk1
            // 
            this.dgv_hk1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hk1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon});
            this.dgv_hk1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_hk1.Location = new System.Drawing.Point(3, 18);
            this.dgv_hk1.Name = "dgv_hk1";
            this.dgv_hk1.RowHeadersWidth = 51;
            this.dgv_hk1.RowTemplate.Height = 24;
            this.dgv_hk1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hk1.Size = new System.Drawing.Size(554, 587);
            this.dgv_hk1.TabIndex = 0;
            // 
            // dgv_hk2
            // 
            this.dgv_hk2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hk2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_hk2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_hk2.Location = new System.Drawing.Point(3, 18);
            this.dgv_hk2.Name = "dgv_hk2";
            this.dgv_hk2.RowHeadersWidth = 51;
            this.dgv_hk2.RowTemplate.Height = 24;
            this.dgv_hk2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hk2.Size = new System.Drawing.Size(554, 294);
            this.dgv_hk2.TabIndex = 1;
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã môn";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.Width = 84;
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên môn học";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaMon";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã môn";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenMon";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên môn học";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // DanhSachMonFromGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 608);
            this.Controls.Add(this.group_Hk2);
            this.Controls.Add(this.group_Hk1);
            this.Name = "DanhSachMonFromGV";
            this.Text = "DanhSachMonFromGV";
            this.Load += new System.EventHandler(this.DanhSachMonFromGV_Load);
            this.group_Hk1.ResumeLayout(false);
            this.group_Hk2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hk2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_Hk1;
        private System.Windows.Forms.GroupBox group_Hk2;
        private System.Windows.Forms.DataGridView dgv_hk1;
        private System.Windows.Forms.DataGridView dgv_hk2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}