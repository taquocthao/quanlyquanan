namespace QuanLyQuanCafe.Form
{
    partial class uctKhuVuc
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
            this.grbTextField = new DevExpress.XtraEditors.GroupControl();
            this.nudSoLuongBan = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTrangThai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhuVuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKhuVuc = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.grvDanhSachKhuVuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soLuongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grbTextField)).BeginInit();
            this.grbTextField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTextField
            // 
            this.grbTextField.Controls.Add(this.nudSoLuongBan);
            this.grbTextField.Controls.Add(this.label4);
            this.grbTextField.Controls.Add(this.label3);
            this.grbTextField.Controls.Add(this.cboTrangThai);
            this.grbTextField.Controls.Add(this.label2);
            this.grbTextField.Controls.Add(this.txtMaKhuVuc);
            this.grbTextField.Controls.Add(this.label1);
            this.grbTextField.Controls.Add(this.txtTenKhuVuc);
            this.grbTextField.Location = new System.Drawing.Point(3, 3);
            this.grbTextField.Name = "grbTextField";
            this.grbTextField.Size = new System.Drawing.Size(245, 201);
            this.grbTextField.TabIndex = 2;
            // 
            // nudSoLuongBan
            // 
            this.nudSoLuongBan.Location = new System.Drawing.Point(94, 166);
            this.nudSoLuongBan.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSoLuongBan.Name = "nudSoLuongBan";
            this.nudSoLuongBan.Size = new System.Drawing.Size(120, 21);
            this.nudSoLuongBan.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng bàn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khu vực :";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.EditValue = "Sử dụng";
            this.cboTrangThai.Location = new System.Drawing.Point(94, 126);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTrangThai.Properties.Items.AddRange(new object[] {
            "Sử dụng",
            "Không sử dụng"});
            this.cboTrangThai.Size = new System.Drawing.Size(120, 20);
            this.cboTrangThai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khu vực :";
            // 
            // txtMaKhuVuc
            // 
            this.txtMaKhuVuc.Enabled = false;
            this.txtMaKhuVuc.Location = new System.Drawing.Point(94, 37);
            this.txtMaKhuVuc.Name = "txtMaKhuVuc";
            this.txtMaKhuVuc.Size = new System.Drawing.Size(120, 21);
            this.txtMaKhuVuc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái : ";
            // 
            // txtTenKhuVuc
            // 
            this.txtTenKhuVuc.Location = new System.Drawing.Point(94, 82);
            this.txtTenKhuVuc.Name = "txtTenKhuVuc";
            this.txtTenKhuVuc.Size = new System.Drawing.Size(120, 21);
            this.txtTenKhuVuc.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(920, 463);
            this.panelControl1.TabIndex = 3;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Location = new System.Drawing.Point(260, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(658, 459);
            this.panelControl3.TabIndex = 21;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.grvDanhSachKhuVuc;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(654, 455);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDanhSachKhuVuc});
            // 
            // grvDanhSachKhuVuc
            // 
            this.grvDanhSachKhuVuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maKhuVuc,
            this.tenKhuVuc,
            this.trangThai,
            this.soLuongBan});
            this.grvDanhSachKhuVuc.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grvDanhSachKhuVuc.GridControl = this.gridControl1;
            this.grvDanhSachKhuVuc.Name = "grvDanhSachKhuVuc";
            this.grvDanhSachKhuVuc.OptionsBehavior.Editable = false;
            this.grvDanhSachKhuVuc.OptionsBehavior.ReadOnly = true;
            this.grvDanhSachKhuVuc.OptionsFind.AlwaysVisible = true;
            this.grvDanhSachKhuVuc.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvDanhSachKhuVuc.OptionsView.ShowGroupPanel = false;
            this.grvDanhSachKhuVuc.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvDanhSachKhuVuc_FocusedRowChanged);
            // 
            // maKhuVuc
            // 
            this.maKhuVuc.AppearanceHeader.Options.UseTextOptions = true;
            this.maKhuVuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maKhuVuc.Caption = "Mã khu vực";
            this.maKhuVuc.FieldName = "maKhuVuc";
            this.maKhuVuc.Name = "maKhuVuc";
            this.maKhuVuc.Visible = true;
            this.maKhuVuc.VisibleIndex = 0;
            // 
            // tenKhuVuc
            // 
            this.tenKhuVuc.AppearanceHeader.Options.UseTextOptions = true;
            this.tenKhuVuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tenKhuVuc.Caption = "Tên khu vực";
            this.tenKhuVuc.FieldName = "tenKhuVuc";
            this.tenKhuVuc.Name = "tenKhuVuc";
            this.tenKhuVuc.Visible = true;
            this.tenKhuVuc.VisibleIndex = 1;
            // 
            // trangThai
            // 
            this.trangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.trangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trangThai.Caption = "Trạng thái";
            this.trangThai.FieldName = "trangThai";
            this.trangThai.Name = "trangThai";
            this.trangThai.Visible = true;
            this.trangThai.VisibleIndex = 2;
            // 
            // soLuongBan
            // 
            this.soLuongBan.Caption = "Số lượng bàn";
            this.soLuongBan.FieldName = "soLuongBan";
            this.soLuongBan.Name = "soLuongBan";
            this.soLuongBan.Visible = true;
            this.soLuongBan.VisibleIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.grbTextField);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(255, 459);
            this.panelControl2.TabIndex = 20;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnThem);
            this.panelControl4.Controls.Add(this.btnSua);
            this.panelControl4.Controls.Add(this.btnHuy);
            this.panelControl4.Controls.Add(this.btnXoa);
            this.panelControl4.Controls.Add(this.btnLuu);
            this.panelControl4.Location = new System.Drawing.Point(2, 210);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(252, 100);
            this.panelControl4.TabIndex = 20;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(11, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(173, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(127, 56);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 35);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(92, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(46, 56);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 35);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // uctKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uctKhuVuc";
            this.Size = new System.Drawing.Size(920, 463);
            ((System.ComponentModel.ISupportInitialize)(this.grbTextField)).EndInit();
            this.grbTextField.ResumeLayout(false);
            this.grbTextField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbTextField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ComboBoxEdit cboTrangThai;
        private System.Windows.Forms.TextBox txtMaKhuVuc;
        private System.Windows.Forms.TextBox txtTenKhuVuc;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDanhSachKhuVuc;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn maKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn tenKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn trangThai;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn soLuongBan;
        private System.Windows.Forms.NumericUpDown nudSoLuongBan;
    }
}
