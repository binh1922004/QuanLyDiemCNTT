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
            this.components = new System.ComponentModel.Container();
            this.dgv_listDKMH = new System.Windows.Forms.DataGridView();
            this.timer_reload = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listDKMH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listDKMH
            // 
            this.dgv_listDKMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listDKMH.Location = new System.Drawing.Point(29, 29);
            this.dgv_listDKMH.Name = "dgv_listDKMH";
            this.dgv_listDKMH.ReadOnly = true;
            this.dgv_listDKMH.RowHeadersWidth = 51;
            this.dgv_listDKMH.RowTemplate.Height = 24;
            this.dgv_listDKMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listDKMH.Size = new System.Drawing.Size(750, 420);
            this.dgv_listDKMH.TabIndex = 0;
            this.dgv_listDKMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listDKMH_CellContentClick);
            // 
            // timer_reload
            // 
            this.timer_reload.Enabled = true;
            this.timer_reload.Interval = 3000;
            this.timer_reload.Tick += new System.EventHandler(this.timer_reload_Tick);
            // 
            // DanhSachDKMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 475);
            this.Controls.Add(this.dgv_listDKMH);
            this.MaximizeBox = false;
            this.Name = "DanhSachDKMH";
            this.Text = "DanhSachDKMH";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listDKMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listDKMH;
        private System.Windows.Forms.Timer timer_reload;
    }
}