using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS;
using QuanLyQuanCafe.DAO;


namespace QuanLyQuanCafe.Form
{
    public partial class uctKhuVuc : UserControl
    {

        public static uctKhuVuc uct = new uctKhuVuc();
        private KhuVucBUS kv = new KhuVucBUS();
        private bool isAdd = false;
        public uctKhuVuc()
        {
            InitializeComponent();

            HienThiDanhSachKhuVuc();
           // EnableProject(false);
        }



        private void HienThiDanhSachKhuVuc()
        {
            gridControl1.DataSource = kv.HienThiDanhSachKhuVuc();
        }

        private void EnableProject(bool e)
        {
            if (e == true)
            {
                grbTextField.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                gridControl1.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else if (e == false)
            {
                grbTextField.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                gridControl1.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        //private string MaTuTang()
        //{
        //    string ma = "NV" + (grvDanhSachKhuVuc.RowCount + 1);
        //    return ma;
        //}

        private void FocusRowChange()
        {
            txtMaKhuVuc.Text = grvDanhSachKhuVuc.GetRowCellValue(grvDanhSachKhuVuc.FocusedRowHandle, "maKhuVuc").ToString();
            txtTenKhuVuc.Text = grvDanhSachKhuVuc.GetRowCellValue(grvDanhSachKhuVuc.FocusedRowHandle, "tenKhuVuc").ToString();
            cboTrangThai.Text = grvDanhSachKhuVuc.GetRowCellValue(grvDanhSachKhuVuc.FocusedRowHandle, "trangThai").ToString();
            nudSoLuongBan.Text = grvDanhSachKhuVuc.GetRowCellValue(grvDanhSachKhuVuc.FocusedRowHandle, "soLuongBan").ToString();
                     
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            EnableProject(true);
            txtMaKhuVuc.Text = "Tự tăng";
            txtTenKhuVuc.Text = null;
            cboTrangThai.Text = "Sử dụng";
            nudSoLuongBan.Value = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaKhuVuc.Text);
            if (kv.XoaKhuVuc(id) == true)
            {
                MessageBox.Show("Xóa khu vực thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa khu vực thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HienThiDanhSachKhuVuc();
            //FocusRowChange();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isAdd = false;
            EnableProject(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            // nếu chọn thêm khu vực
            if (isAdd)
            {
                KhuVuc k = new KhuVuc();
                //k.maKhuVuc = Convert.ToInt32(txtMaKhuVuc.Text);
                k.tenKhuVuc = txtTenKhuVuc.Text;
                k.trangThai = cboTrangThai.SelectedItem.ToString();
                k.soLuongBan = (int)nudSoLuongBan.Value;

                bool success = kv.ThemKhuVuc(k);
                if (success)
                {
                    MessageBox.Show("Thêm khu vực thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //FocusRowChange();                
                }
                else
                {
                    MessageBox.Show("Thêm khu vực thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // cập nhật thông tin khu vực
            {
                KhuVuc k = new KhuVuc();
                k.maKhuVuc = Convert.ToInt32(txtMaKhuVuc.Text);
                k.tenKhuVuc = txtTenKhuVuc.Text;
                k.trangThai = cboTrangThai.SelectedItem.ToString();
                k.soLuongBan = (int)nudSoLuongBan.Value;

                bool sucess = kv.SuaKhuVuc(k);

                if (sucess)
                {
                    MessageBox.Show("Cập nhật khu vực thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Cập nhật khu vực thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            EnableProject(false);
            HienThiDanhSachKhuVuc();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EnableProject(false);
            if (grvDanhSachKhuVuc.RowCount > 0)
                FocusRowChange();
        }

        private void grvDanhSachKhuVuc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FocusRowChange();
        }


    }
}
