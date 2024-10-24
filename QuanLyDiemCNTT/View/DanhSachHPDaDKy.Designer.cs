namespace QuanLyDiemCNTT.view
{
    partial class DanhSachHPDaDKy
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
            this.dgv_DSHP = new System.Windows.Forms.DataGridView();
            this.cb_semster = new System.Windows.Forms.ComboBox();
            this.lb_semster = new System.Windows.Forms.Label();
            this.lb_DSHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DSHP
            // 
            this.dgv_DSHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSHP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DSHP.Location = new System.Drawing.Point(0, 159);
            this.dgv_DSHP.Name = "dgv_DSHP";
            this.dgv_DSHP.ReadOnly = true;
            this.dgv_DSHP.RowHeadersWidth = 51;
            this.dgv_DSHP.RowTemplate.Height = 24;
            this.dgv_DSHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSHP.Size = new System.Drawing.Size(1097, 426);
            this.dgv_DSHP.TabIndex = 1;
            this.dgv_DSHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSHP_CellClick);
            // 
            // cb_semster
            // 
            this.cb_semster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_semster.FormattingEnabled = true;
            this.cb_semster.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_semster.Location = new System.Drawing.Point(85, 35);
            this.cb_semster.Name = "cb_semster";
            this.cb_semster.Size = new System.Drawing.Size(136, 24);
            this.cb_semster.TabIndex = 3;
            this.cb_semster.SelectedIndexChanged += new System.EventHandler(this.cb_semster_SelectedIndexChanged);
            // 
            // lb_semster
            // 
            this.lb_semster.AutoSize = true;
            this.lb_semster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_semster.Location = new System.Drawing.Point(2, 39);
            this.lb_semster.Name = "lb_semster";
            this.lb_semster.Size = new System.Drawing.Size(66, 20);
            this.lb_semster.TabIndex = 4;
            this.lb_semster.Text = "Học kỳ:";
            // 
            // lb_DSHP
            // 
            this.lb_DSHP.AutoSize = true;
            this.lb_DSHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DSHP.Location = new System.Drawing.Point(309, 9);
            this.lb_DSHP.Name = "lb_DSHP";
            this.lb_DSHP.Size = new System.Drawing.Size(411, 32);
            this.lb_DSHP.TabIndex = 5;
            this.lb_DSHP.Text = "Danh sách học phần đã đăng kí";
            // 
            // DanhSachHPDaDKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 585);
            this.Controls.Add(this.lb_DSHP);
            this.Controls.Add(this.lb_semster);
            this.Controls.Add(this.cb_semster);
            this.Controls.Add(this.dgv_DSHP);
            this.MaximizeBox = false;
            this.Name = "DanhSachHPDaDKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachHPDaDKy";
            this.Load += new System.EventHandler(this.DanhSachHPDaDKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DSHP;
        private System.Windows.Forms.ComboBox cb_semster;
        private System.Windows.Forms.Label lb_semster;
        private System.Windows.Forms.Label lb_DSHP;
    }
}