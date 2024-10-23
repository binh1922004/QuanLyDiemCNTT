namespace QuanLyDiemCNTT.view
{
    partial class DanhSachLopFromGV
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
            this.dgv_lop = new System.Windows.Forms.DataGridView();
            this.lbl_MaMon = new System.Windows.Forms.Label();
            this.lbl_TenMon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_lop
            // 
            this.dgv_lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_lop.Location = new System.Drawing.Point(0, 167);
            this.dgv_lop.Name = "dgv_lop";
            this.dgv_lop.ReadOnly = true;
            this.dgv_lop.RowHeadersWidth = 51;
            this.dgv_lop.RowTemplate.Height = 24;
            this.dgv_lop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lop.Size = new System.Drawing.Size(904, 387);
            this.dgv_lop.TabIndex = 0;
            // 
            // lbl_MaMon
            // 
            this.lbl_MaMon.AutoSize = true;
            this.lbl_MaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaMon.Location = new System.Drawing.Point(12, 22);
            this.lbl_MaMon.Name = "lbl_MaMon";
            this.lbl_MaMon.Size = new System.Drawing.Size(94, 25);
            this.lbl_MaMon.TabIndex = 1;
            this.lbl_MaMon.Text = "Mã môn: ";
            // 
            // lbl_TenMon
            // 
            this.lbl_TenMon.AutoSize = true;
            this.lbl_TenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenMon.Location = new System.Drawing.Point(12, 72);
            this.lbl_TenMon.Name = "lbl_TenMon";
            this.lbl_TenMon.Size = new System.Drawing.Size(101, 25);
            this.lbl_TenMon.TabIndex = 2;
            this.lbl_TenMon.Text = "Tên môn: ";
            // 
            // DanhSachLopFromGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 554);
            this.Controls.Add(this.lbl_TenMon);
            this.Controls.Add(this.lbl_MaMon);
            this.Controls.Add(this.dgv_lop);
            this.Name = "DanhSachLopFromGV";
            this.Text = "DanhSachLopFromGV";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_lop;
        private System.Windows.Forms.Label lbl_MaMon;
        private System.Windows.Forms.Label lbl_TenMon;
    }
}