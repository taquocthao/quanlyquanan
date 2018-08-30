namespace QuanLyQuanCafe.Form
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblThongBao = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.CheckButton();
            this.btnDangNhap = new DevExpress.XtraEditors.CheckButton();
            this.lblTaoTaiKhoan = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.chkLuuTaiKhoan = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkLuuTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(519, 66);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(129, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(246, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor2 = System.Drawing.Color.LightCyan;
            this.panelControl2.Appearance.BorderColor = System.Drawing.Color.LightCyan;
            this.panelControl2.Appearance.Options.UseBorderColor = true;
            this.panelControl2.Controls.Add(this.lblThongBao);
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnDangNhap);
            this.panelControl2.Controls.Add(this.lblTaoTaiKhoan);
            this.panelControl2.Controls.Add(this.chkLuuTaiKhoan);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Controls.Add(this.pictureEdit1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 66);
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(519, 321);
            this.panelControl2.TabIndex = 1;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Appearance.Options.UseForeColor = true;
            this.lblThongBao.Location = new System.Drawing.Point(227, 228);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 13);
            this.lblThongBao.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(326, 258);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.ToolTip = "Thoát";
            this.btnThoat.CheckedChanged += new System.EventHandler(this.btnThoat_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(227, 258);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.ToolTip = "Đăng nhập";
            this.btnDangNhap.CheckedChanged += new System.EventHandler(this.btnDangNhap_CheckedChanged);
            // 
            // lblTaoTaiKhoan
            // 
            this.lblTaoTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTaoTaiKhoan.Location = new System.Drawing.Point(227, 198);
            this.lblTaoTaiKhoan.Name = "lblTaoTaiKhoan";
            this.lblTaoTaiKhoan.Size = new System.Drawing.Size(65, 13);
            this.lblTaoTaiKhoan.TabIndex = 4;
            this.lblTaoTaiKhoan.Text = "Tạo tài khoản";
            this.lblTaoTaiKhoan.ToolTip = "tạo tài khoản";
            // 
            // chkLuuTaiKhoan
            // 
            this.chkLuuTaiKhoan.Location = new System.Drawing.Point(227, 164);
            this.chkLuuTaiKhoan.Name = "chkLuuTaiKhoan";
            this.chkLuuTaiKhoan.Properties.Caption = "Lưu tài khoản";
            this.chkLuuTaiKhoan.Size = new System.Drawing.Size(87, 19);
            this.chkLuuTaiKhoan.TabIndex = 3;
            this.chkLuuTaiKhoan.ToolTip = "Lưu tài khoản";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtTaiKhoan);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(227, 27);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(277, 123);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin đăng nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.EditValue = "123";
            this.txtMatKhau.Location = new System.Drawing.Point(82, 78);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(170, 20);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.ToolTip = "nhập mật khẩu";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Mật khẩu :";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.EditValue = "admin";
            this.txtTaiKhoan.Location = new System.Drawing.Point(82, 36);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(170, 20);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.ToolTip = "nhập tài khoản";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Tài khoản :";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 27);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Size = new System.Drawing.Size(193, 254);
            this.pictureEdit1.TabIndex = 1;
            // 
            // frmDangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.Cyan;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 387);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkLuuTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkLuuTaiKhoan;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblTaoTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckButton btnThoat;
        private DevExpress.XtraEditors.CheckButton btnDangNhap;
        private DevExpress.XtraEditors.LabelControl lblThongBao;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
    }
}