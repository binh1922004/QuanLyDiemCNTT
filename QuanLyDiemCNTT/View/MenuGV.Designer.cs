namespace QuanLyDiemCNTT.view
{
    partial class MenuGV
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
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_MH = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Form
            // 
            this.pnl_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Form.Location = new System.Drawing.Point(156, 0);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(824, 630);
            this.pnl_Form.TabIndex = 5;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.btn_MH);
            this.pnl_Menu.Controls.Add(this.btn_Info);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(156, 630);
            this.pnl_Menu.TabIndex = 4;
            // 
            // btn_MH
            // 
            this.btn_MH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MH.Location = new System.Drawing.Point(0, 44);
            this.btn_MH.Name = "btn_MH";
            this.btn_MH.Size = new System.Drawing.Size(156, 44);
            this.btn_MH.TabIndex = 1;
            this.btn_MH.Text = "Danh sách môn";
            this.btn_MH.UseVisualStyleBackColor = true;
            this.btn_MH.Click += new System.EventHandler(this.btn_MH_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Info.Location = new System.Drawing.Point(0, 0);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(156, 44);
            this.btn_Info.TabIndex = 0;
            this.btn_Info.Text = "Xem thông tin";
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // MenuGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 630);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.pnl_Menu);
            this.Name = "MenuGV";
            this.Text = "MenuGV";
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button btn_MH;
        private System.Windows.Forms.Button btn_Info;
    }
}