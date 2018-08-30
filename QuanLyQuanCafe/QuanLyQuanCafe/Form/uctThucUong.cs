using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS;

namespace QuanLyQuanCafe.Form
{
    public partial class uctThucUong : UserControl
    {
        public static uctThucUong uct = new uctThucUong();
        //private bool isAdd = false;

        public uctThucUong()
        {
            InitializeComponent();
            EnableProject(false);
        }    

        #region Function, Giao diện
        //
        private void HienThiDanhSachThucUong()
        {

        }

        private void HienThiDanhSachThuocUongTheoLoai(string id)
        {

        }

        private void EnableProject(bool e)
        {
            if (e == true)
            {
                pnlTextField.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                flpDanhSachThucUong.Enabled = false;
            }
            else
            {
                pnlTextField.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                flpDanhSachThucUong.Enabled = true;
            }
        }

        private void FocusObject()
        {

        }
        //
        #endregion

        #region Các button xử lý
        //
        private void btnThem_Click(object sender, EventArgs e)
        {
           // isAdd = true;
            EnableProject(true);
            txtMaThucUong.Text = "Tự tăng";
            txtTenThucUong.Text = null;
            txtDvt.Text = null;
            txtDonGia.Text = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           // isAdd = false;
            EnableProject(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            EnableProject(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EnableProject(false);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
        //
        #endregion
    }
}
