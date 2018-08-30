using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System.Reflection;
using System.IO;


namespace QuanLyQuanCafe
{
    public partial class frmGiaoDienChinh : DevExpress.XtraEditors.XtraForm
    {
        public static frmGiaoDienChinh frm = new frmGiaoDienChinh();      
        public string tenNV = "";
        string smss = "";


        public frmGiaoDienChinh()
        {
            InitializeComponent();
            
        }

        private void frmGiaoDienChinh_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Caption = tenNV;
            
            Form.uctHeThong uct = new Form.uctHeThong();
            uct.send += uct_send;
            ThemTabPages(uct, 4, "Bảng theo dõi");
        }

        private void uct_send(string sms)
        {
            smss = sms;
            ThemTabPages(Form.uctGoiMon.uct, 4, "Gọi món");
        }


        #region Hàm thêm tab mới cho giao diện
        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            for (int i = 0; i < tabHienThi.TabPages.Count; i++)
            {
                if (tabHienThi.TabPages[i].Contains(uct) == true)
                {
                    tabHienThi.SelectedTabPage = tabHienThi.TabPages[i];                  
                    return;
                }
            } 
            DevExpress.XtraTab.XtraTabPage tab = new DevExpress.XtraTab.XtraTabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = tabHienThi.Size;
            tab.Text = tenTab;
            tabHienThi.TabPages.Add(tab);
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }

        #endregion

        #region Danh mục Hệ Thống
        private void btnBangTheoDoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTabPages(Form.uctHeThong.uct, 4, "Bảng theo dõi");
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            Form.frmDangNhap frm = new Form.frmDangNhap();
            frm.ShowDialog();
            this.Close();
        }

        #endregion

        #region Danh mục Quản Lý
        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTabPages(Form.uctNhanVien.uctNhanvien, 4,"Quản lý nhân viên");
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region Danh Mục Khu vực bàn
        private void btnKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTabPages(Form.uctKhuVuc.uct, 4, "Quản lý khu vực");

        }

        private void btnBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTabPages(Form.uctBan.uct, 4, "Quản lý bàn");
        }
        #endregion

        #region Danh mục Thực Đơn


        private void btnLoaiThucPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTabPages(Form.uctLoaiThucPham.uct, 4, "Quản lý loại thực phẩm");
        }

        private void btnThucUong_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTabPages(Form.uctThucUong.uct, 4, "Quản lý Thức Uống");
        }

        private void btnThucAn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTabPages(Form.uctThucAn.uct, 4, "Quản lý Thức Ăn");
        }

        #endregion

        #region Danh mục Gọi Món
        public void btnGoiMon_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTabPages(Form.uctGoiMon.uct, 4, "Gọi món");
        }

        #endregion

        #region Danh mục Báo Cáo
        private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTabPages(Form.uctThongKeHoaDon.uct, 4, "Lịch sử hóa đơn");
        }
        #endregion

        #region Danh mục Trợ giúp

        private void btnLienHe_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/291036544680121");
        }

        private void btnHuongDanSuDung_ItemClick(object sender, ItemClickEventArgs e)
        {

            string path = Path.Combine(Path.GetTempPath(), "HUONG_DAN_SU_DUNG.docx");
            File.WriteAllBytes(path, QuanLyQuanCafe.Properties.Resources.HUONG_DAN_SU_DUNG);
            System.Diagnostics.Process.Start(path);

        }

        #endregion

        #region Thoát
        private void btnDongChuongTrinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dlgrs = XtraMessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgrs == DialogResult.Yes)
                this.Close();
            else
                return;
        }

        private void btnDangXuat2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            Form.frmDangNhap frm = new Form.frmDangNhap();
            frm.ShowDialog();
            this.Close();
        }
        #endregion

        #region Sự kiện mở, đóng form
        // sự kiện đóng form
        private void tabHienThi_CloseButtonClick(object sender, EventArgs e)
        {
            tabHienThi.TabPages.Remove(tabHienThi.SelectedTabPage);
        }

        // sự kiện nhảy đến from được mở
        private void tabHienThi_ControlAdded(object sender, ControlEventArgs e)
        {
            tabHienThi.SelectedTabPageIndex = tabHienThi.TabPages.Count - 1;
        }
        #endregion

        private void btnQuanLyKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnQuanLyBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnThucPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTabPages(Form.uctThucPham.uct, 4, "Quản lý thực đơn");
        }



    }
}