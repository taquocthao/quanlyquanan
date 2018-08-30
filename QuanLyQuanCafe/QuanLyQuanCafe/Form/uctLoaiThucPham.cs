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
    public partial class uctLoaiThucPham : UserControl
    {
        public static uctLoaiThucPham uct = new uctLoaiThucPham();
        private LoaiThucPhamBUS loaiTP = new LoaiThucPhamBUS();
        private bool isADD = false;

        public uctLoaiThucPham()
        {
            InitializeComponent();
            HienThiDanhSachLoaiThucPham();
            EnableProject(false);
        }


        #region Giao diện, Hàm
        //
        private void HienThiDanhSachLoaiThucPham()
        {
            gridControl1.DataSource = loaiTP.HienThiDanhSachLoaiThucPham();
        }

        private void EnableProject(bool e)
        {
            if (e == true)
            {
                pnlTextfield.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;

            }
            else if (e == false)
            {
                pnlTextfield.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
        }


        private void FocusRowChanged()
        {
             txtMaLoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "maLoaiTP").ToString();
            txtTenLoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "tenLoaiTP").ToString();
          
        }
        //
        #endregion


        #region Thao tác thêm, sửa, xóa
        //
        private void btnThem_Click(object sender, EventArgs e)
        {
            isADD = true;
            EnableProject(true);
            txtMaLoai.Text = "Tự tăng";
            txtTenLoai.Text = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isADD = false;
            EnableProject(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaLoai.Text);
            bool success = loaiTP.Xoa(id);
            if (success == true)
            {
                MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // xóa thất bại
            {
                MessageBox.Show("Xóa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            EnableProject(false);
            HienThiDanhSachLoaiThucPham();
            FocusRowChanged();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EnableProject(false);
            FocusRowChanged();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LoaiThucPham x = new LoaiThucPham();
            
            if (isADD)
            {
                //x.maLoaiTP = Convert.ToInt32(txtMaLoai.Text);
                x.tenLoaiTP = txtTenLoai.Text;
                bool success = loaiTP.Them(x);
                if (success)
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // thêm thất bại
                {
                    MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // sửa 
            {
                x.maLoaiTP = Convert.ToInt32(txtMaLoai.Text);
                x.tenLoaiTP = txtTenLoai.Text;
                bool success = loaiTP.Sua(x);
                if (success)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // thêm thất bại
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            HienThiDanhSachLoaiThucPham();
            EnableProject(false);
            FocusRowChanged();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FocusRowChanged();
        }
        //
        #endregion

    }
}
