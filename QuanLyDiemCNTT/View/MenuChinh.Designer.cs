﻿namespace QuanLyDiemCNTT.view
{
    partial class MenuChinh
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
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_xemDiem = new System.Windows.Forms.Button();
            this.btn_xemThongTin = new System.Windows.Forms.Button();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.btn_xemDiem);
            this.pnl_Menu.Controls.Add(this.btn_xemThongTin);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(234, 628);
            this.pnl_Menu.TabIndex = 3;
            // 
            // btn_xemDiem
            // 
            this.btn_xemDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_xemDiem.Location = new System.Drawing.Point(0, 69);
            this.btn_xemDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xemDiem.Name = "btn_xemDiem";
            this.btn_xemDiem.Size = new System.Drawing.Size(234, 69);
            this.btn_xemDiem.TabIndex = 1;
            this.btn_xemDiem.Text = "Xem điểm";
            this.btn_xemDiem.UseVisualStyleBackColor = true;
            this.btn_xemDiem.Click += new System.EventHandler(this.btn_xemDiem_Click);
            // 
            // btn_xemThongTin
            // 
            this.btn_xemThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_xemThongTin.Location = new System.Drawing.Point(0, 0);
            this.btn_xemThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xemThongTin.Name = "btn_xemThongTin";
            this.btn_xemThongTin.Size = new System.Drawing.Size(234, 69);
            this.btn_xemThongTin.TabIndex = 0;
            this.btn_xemThongTin.Text = "Xem thông tin cá nhân";
            this.btn_xemThongTin.UseVisualStyleBackColor = true;
            this.btn_xemThongTin.Click += new System.EventHandler(this.btn_xemThongTin_Click);
            // 
            // pnl_Form
            // 
            this.pnl_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Form.Location = new System.Drawing.Point(234, 0);
            this.pnl_Form.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(944, 628);
            this.pnl_Form.TabIndex = 4;
            // 
            // MenuChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 628);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.pnl_Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu chính";
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button btn_xemDiem;
        private System.Windows.Forms.Button btn_xemThongTin;
        private System.Windows.Forms.Panel pnl_Form;
    }
}