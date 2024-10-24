namespace QuanLyDiemCNTT.view
{
    partial class BangDiemSV
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
            this.grb_hk1 = new System.Windows.Forms.GroupBox();
            this.dgv_hk1 = new System.Windows.Forms.DataGridView();
            this.grb_hk2 = new System.Windows.Forms.GroupBox();
            this.dgv_hk2 = new System.Windows.Forms.DataGridView();
            this.grb_hk1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hk1)).BeginInit();
            this.grb_hk2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hk2)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_hk1
            // 
            this.grb_hk1.Controls.Add(this.dgv_hk1);
            this.grb_hk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_hk1.Location = new System.Drawing.Point(12, 12);
            this.grb_hk1.Name = "grb_hk1";
            this.grb_hk1.Size = new System.Drawing.Size(713, 336);
            this.grb_hk1.TabIndex = 0;
            this.grb_hk1.TabStop = false;
            this.grb_hk1.Text = "Học kỳ 1";
            // 
            // dgv_hk1
            // 
            this.dgv_hk1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hk1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hk1.Location = new System.Drawing.Point(6, 21);
            this.dgv_hk1.Name = "dgv_hk1";
            this.dgv_hk1.ReadOnly = true;
            this.dgv_hk1.RowHeadersWidth = 51;
            this.dgv_hk1.RowTemplate.Height = 24;
            this.dgv_hk1.Size = new System.Drawing.Size(701, 309);
            this.dgv_hk1.TabIndex = 0;
            this.dgv_hk1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hk1_CellClick);
            // 
            // grb_hk2
            // 
            this.grb_hk2.Controls.Add(this.dgv_hk2);
            this.grb_hk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_hk2.Location = new System.Drawing.Point(12, 354);
            this.grb_hk2.Name = "grb_hk2";
            this.grb_hk2.Size = new System.Drawing.Size(713, 344);
            this.grb_hk2.TabIndex = 0;
            this.grb_hk2.TabStop = false;
            this.grb_hk2.Text = "Học kỳ 2";
            // 
            // dgv_hk2
            // 
            this.dgv_hk2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hk2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hk2.Location = new System.Drawing.Point(6, 24);
            this.dgv_hk2.Name = "dgv_hk2";
            this.dgv_hk2.ReadOnly = true;
            this.dgv_hk2.RowHeadersWidth = 51;
            this.dgv_hk2.RowTemplate.Height = 24;
            this.dgv_hk2.Size = new System.Drawing.Size(701, 314);
            this.dgv_hk2.TabIndex = 0;
            this.dgv_hk2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hk2_CellClick);
            // 
            // BangDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 710);
            this.Controls.Add(this.grb_hk2);
            this.Controls.Add(this.grb_hk1);
            this.Name = "BangDiemSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BangDiemSV";
            this.grb_hk1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hk1)).EndInit();
            this.grb_hk2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hk2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_hk1;
        private System.Windows.Forms.DataGridView dgv_hk1;
        private System.Windows.Forms.GroupBox grb_hk2;
        private System.Windows.Forms.DataGridView dgv_hk2;
    }
}