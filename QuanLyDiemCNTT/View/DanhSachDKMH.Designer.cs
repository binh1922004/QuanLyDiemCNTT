namespace QuanLyDiemCNTT.view
{
    partial class DanhSachDKMH
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
            this.dgv_listDKMH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listDKMH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listDKMH
            // 
            this.dgv_listDKMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listDKMH.Location = new System.Drawing.Point(29, 29);
            this.dgv_listDKMH.Name = "dgv_listDKMH";
            this.dgv_listDKMH.RowHeadersWidth = 51;
            this.dgv_listDKMH.RowTemplate.Height = 24;
            this.dgv_listDKMH.Size = new System.Drawing.Size(750, 420);
            this.dgv_listDKMH.TabIndex = 0;
            // 
            // DanhSachDKMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 475);
            this.Controls.Add(this.dgv_listDKMH);
            this.Name = "DanhSachDKMH";
            this.Text = "DanhSachDKMH";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listDKMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listDKMH;
    }
}