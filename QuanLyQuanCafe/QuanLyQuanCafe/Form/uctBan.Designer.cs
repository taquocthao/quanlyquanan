namespace QuanLyQuanCafe.Form
{
    partial class uctBan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.pnlTextfield = new DevExpress.XtraEditors.PanelControl();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numSoLuongBan = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTrangThai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.flpDanhSachBan = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTextfield)).BeginInit();
            this.pnlTextfield.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(121, 46);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 35);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(5, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(40, 46);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 35);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(86, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.pnlTextfield);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(252, 460);
            this.panelControl2.TabIndex = 20;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.label5);
            this.panelControl5.Controls.Add(this.cboKhuVuc);
            this.panelControl5.Location = new System.Drawing.Point(3, 5);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(247, 52);
            this.panelControl5.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Khu vực :";
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(106, 16);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(120, 21);
            this.cboKhuVuc.TabIndex = 1;
            this.cboKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cboKhuVuc_SelectedIndexChanged);
            // 
            // pnlTextfield
            // 
            this.pnlTextfield.Controls.Add(this.txtMaBan);
            this.pnlTextfield.Controls.Add(this.label3);
            this.pnlTextfield.Controls.Add(this.numSoLuongBan);
            this.pnlTextfield.Controls.Add(this.label4);
            this.pnlTextfield.Controls.Add(this.cboTrangThai);
            this.pnlTextfield.Controls.Add(this.label2);
            this.pnlTextfield.Controls.Add(this.label1);
            this.pnlTextfield.Controls.Add(this.txtTenBan);
            this.pnlTextfield.Location = new System.Drawing.Point(3, 62);
            this.pnlTextfield.Name = "pnlTextfield";
            this.pnlTextfield.Size = new System.Drawing.Size(249, 211);
            this.pnlTextfield.TabIndex = 21;
            // 
            // txtMaBan
            // 
            this.txtMaBan.Enabled = false;
            this.txtMaBan.Location = new System.Drawing.Point(109, 21);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(120, 21);
            this.txtMaBan.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã bàn:";
            // 
            // numSoLuongBan
            // 
            this.numSoLuongBan.Location = new System.Drawing.Point(109, 164);
            this.numSoLuongBan.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSoLuongBan.Name = "numSoLuongBan";
            this.numSoLuongBan.Size = new System.Drawing.Size(120, 21);
            this.numSoLuongBan.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số lượng : ";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Location = new System.Drawing.Point(109, 120);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTrangThai.Properties.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.cboTrangThai.Size = new System.Drawing.Size(120, 20);
            this.cboTrangThai.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên bàn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Trạng thái : ";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(109, 68);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(120, 21);
            this.txtTenBan.TabIndex = 16;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(82, 387);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(82, 44);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Thêm nhanh";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnThem);
            this.panelControl4.Controls.Add(this.btnSua);
            this.panelControl4.Controls.Add(this.btnHuy);
            this.panelControl4.Controls.Add(this.btnXoa);
            this.panelControl4.Controls.Add(this.btnLuu);
            this.panelControl4.Location = new System.Drawing.Point(3, 279);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(249, 87);
            this.panelControl4.TabIndex = 20;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(169, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.flpDanhSachBan);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(897, 464);
            this.panelControl1.TabIndex = 4;
            // 
            // flpDanhSachBan
            // 
            this.flpDanhSachBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDanhSachBan.AutoScroll = true;
            this.flpDanhSachBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpDanhSachBan.Location = new System.Drawing.Point(256, 2);
            this.flpDanhSachBan.Name = "flpDanhSachBan";
            this.flpDanhSachBan.Size = new System.Drawing.Size(638, 460);
            this.flpDanhSachBan.TabIndex = 21;
            // 
            // uctBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "uctBan";
            this.Size = new System.Drawing.Size(897, 464);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTextfield)).EndInit();
            this.pnlTextfield.ResumeLayout(false);
            this.pnlTextfield.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSachBan;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl pnlTextfield;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSoLuongBan;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit cboTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenBan;
        private DevExpress.XtraEditors.PanelControl panelControl5;
    }
}
