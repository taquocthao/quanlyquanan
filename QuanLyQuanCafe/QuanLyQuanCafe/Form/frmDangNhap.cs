using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyQuanCafe.BUS;

namespace QuanLyQuanCafe.Form
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private NhanVienBUS nv = new NhanVienBUS();
        public frmDangNhap()
        {
            InitializeComponent();
            
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                txtTaiKhoan.Text = Properties.Settings.Default.username;
                txtMatKhau.Text = Properties.Settings.Default.password;
            }

            txtTaiKhoan.Text = "admin";
            txtMatKhau.Text = "123";
        }

        private void btnThoat_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnDangNhap_CheckedChanged(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();
            if (chkLuuTaiKhoan.Checked)
            {
                Properties.Settings.Default.username = user;
                Properties.Settings.Default.password = pass;
                Properties.Settings.Default.Save();
            }
            if (user == "" || pass == "")
            {
                lblThongBao.Text = "Tài khoản hoặc mật khẩu không được để trống!";
            }
            else
            {                              
                bool checkLogin = nv.KiemTraDangNhap(user, pass);
                if(checkLogin)
                {
                    string tenNV = nv.LayTenNhanVienTuTaiKhoan(user, pass);

                    Properties.Settings.Default.username = user;
                    Properties.Settings.Default.password = pass;
                    Properties.Settings.Default.Save();

                    this.Hide();
                    frmGiaoDienChinh frm = new frmGiaoDienChinh();
                    frm.tenNV = tenNV;
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblThongBao.Text = "Đăng nhập thất bại! vui lòng thử lại";
                    txtTaiKhoan.Text = "";
                    txtTaiKhoan.Focus();
                    txtMatKhau.Text = "";
                }
                    
            }
        }

      
    }
}