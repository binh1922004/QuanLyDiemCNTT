namespace QuanLyDiemCNTT.view
{
    partial class DanhSachDKHP
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
            this.btn_DangKy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DSHP
            // 
            this.dgv_DSHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSHP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DSHP.Location = new System.Drawing.Point(0, 86);
            this.dgv_DSHP.Name = "dgv_DSHP";
            this.dgv_DSHP.ReadOnly = true;
            this.dgv_DSHP.RowHeadersWidth = 51;
            this.dgv_DSHP.RowTemplate.Height = 24;
            this.dgv_DSHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSHP.Size = new System.Drawing.Size(943, 491);
            this.dgv_DSHP.TabIndex = 0;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.Location = new System.Drawing.Point(767, 29);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(129, 51);
            this.btn_DangKy.TabIndex = 1;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // DanhSachDKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 577);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.dgv_DSHP);
            this.MaximizeBox = false;
            this.Name = "DanhSachDKHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachDKHP";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DSHP;
        private System.Windows.Forms.Button btn_DangKy;
    }
}