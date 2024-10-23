namespace QuanLyDiemCNTT.view
{
    partial class ChiTietDiem
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
            this.lb_qt = new System.Windows.Forms.Label();
            this.lb_kt = new System.Windows.Forms.Label();
            this.lb_header = new System.Windows.Forms.Label();
            this.lb_mh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_qt
            // 
            this.lb_qt.AutoSize = true;
            this.lb_qt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_qt.Location = new System.Drawing.Point(43, 145);
            this.lb_qt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_qt.Name = "lb_qt";
            this.lb_qt.Size = new System.Drawing.Size(137, 25);
            this.lb_qt.TabIndex = 0;
            this.lb_qt.Text = "Điểm quá trình";
            // 
            // lb_kt
            // 
            this.lb_kt.AutoSize = true;
            this.lb_kt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_kt.Location = new System.Drawing.Point(43, 209);
            this.lb_kt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kt.Name = "lb_kt";
            this.lb_kt.Size = new System.Drawing.Size(130, 25);
            this.lb_kt.TabIndex = 0;
            this.lb_kt.Text = "Điểm kết thúc";
            // 
            // lb_header
            // 
            this.lb_header.AutoSize = true;
            this.lb_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_header.Location = new System.Drawing.Point(111, 9);
            this.lb_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(185, 32);
            this.lb_header.TabIndex = 0;
            this.lb_header.Text = "Điểm Chi Tiết";
            // 
            // lb_mh
            // 
            this.lb_mh.AutoSize = true;
            this.lb_mh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_mh.Location = new System.Drawing.Point(13, 77);
            this.lb_mh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mh.Name = "lb_mh";
            this.lb_mh.Size = new System.Drawing.Size(88, 25);
            this.lb_mh.TabIndex = 0;
            this.lb_mh.Text = "Môn học";
            // 
            // ChiTietDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 284);
            this.Controls.Add(this.lb_kt);
            this.Controls.Add(this.lb_header);
            this.Controls.Add(this.lb_mh);
            this.Controls.Add(this.lb_qt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChiTietDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietDiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_qt;
        private System.Windows.Forms.Label lb_kt;
        private System.Windows.Forms.Label lb_header;
        private System.Windows.Forms.Label lb_mh;
    }
}