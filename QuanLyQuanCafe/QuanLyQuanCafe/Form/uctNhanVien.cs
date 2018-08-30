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
    public partial class uctNhanVien : UserControl
    {
        public static uctNhanVien uctNhanvien = new uctNhanVien();
        private NhanVienBUS nv = new NhanVienBUS();
        private bool isAdd = false;
        public uctNhanVien()
        {
            InitializeComponent();
            HienThiDanhSachNhanVien();
            EnableProject(false);
           // FocusRowChange();
        }

        private void HienThiDanhSachNhanVien()
        {
           gridDanhSachNhanVien.DataSource = nv.HienThiDanhSachNhanVien();
        }

        private void EnableProject(bool e)
        {
            if (e == true)
            {
                grbTextfield.Enabled = true;
                btnThemNhanVien.Enabled = false;
                btnXoaNhanVien.Enabled = false;
                btnSuaNhanVien.Enabled = false;
                gridDanhSachNhanVien.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else if (e == false) 
            {
                grbTextfield.Enabled = false;
                btnThemNhanVien.Enabled = true;
                btnXoaNhanVien.Enabled = true;
                btnSuaNhanVien.Enabled = true;
                gridDanhSachNhanVien.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private string MaTuTang()
        {
            string ma = "NV" + (gridView1.RowCount+1);
            return ma;
        }

        private void FocusRowChange()
        {
            txtMaNhanVien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "maNhanVien").ToString();
            txtSoCMND.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "soCMND").ToString();
            txtHoLot.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "hoLot").ToString();
            txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ten").ToString();
            txtSDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "sdt").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "diaChi").ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "gioiTinh").ToString().Equals("nam") ||
                gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "gioiTinh").ToString().Equals("Nam"))
                rdnam.Checked = true;
            else
                rdnu.Checked = true;
            cboChucVu.SelectedItem = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "chucVu").ToString();
            dtpNgayLam.Value = (DateTime)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ngayLam");
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            EnableProject(true);
            isAdd = true;

            txtMaNhanVien.Text = "Tự tăng";
            txtHoLot.Text = null;
            txtTen.Text = null;
            rdnam.Checked = false;
            rdnu.Checked = false;
            cboChucVu.Text = "Quản lý";
            txtDiaChi.Text = null;
            txtSoCMND.Text = null;
            dtpNgayLam.Text = null;
            txtSDT.Text = null;
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            EnableProject(true);
            isAdd = false;
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaNhanVien.Text);
            if (nv.XoaNhanVien(id))
            {
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HienThiDanhSachNhanVien();
            FocusRowChange();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            NhanVien n = new NhanVien();
           // n.maNhanVien = txtMaNhanVien.Text;
            n.hoLot = txtHoLot.Text;
            n.ten = txtTen.Text;
            if(rdnam.Checked)
                n.gioiTinh = "Nam";
            else
                n.gioiTinh = "Nữ";
            n.chucVu = cboChucVu.Text;
            n.diaChi = txtDiaChi.Text;
            n.sdt = txtSDT.Text;
            n.soCMND = txtSoCMND.Text;
            n.ngayLam = dtpNgayLam.Value;
            //nếu thao tác thêm nhân viên           
            if (isAdd)
            {
                bool success = nv.ThemNhanVien(n);
                if (success)
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // sửa thông tin nhân viên
            {
                bool success = nv.SuaNhanVien(n);
                if (success)
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            EnableProject(false);
            HienThiDanhSachNhanVien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EnableProject(false);
            FocusRowChange();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FocusRowChange();
        }

        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //public string MaTuTang()
        //{
        //    QuanLyQuanCafeDataContext db = new QuanLyQuanCafeDataContext();
        //    var danhSachNhanVien = (from nv in db.NhanViens select nv).ToList(); 
        //    dtNV = ConvertToDatatable.ToDataTable(danhSachNhanVien);
        //    string ma = "";
        //    if (dtNV.Rows.Count <= 0)
        //    {
        //        ma = "NV001";
        //    }
        //    else
        //    {
        //        int k;
        //        ma = "NV";
        //        k = Convert.ToInt32(dtNV.Rows[dtNV.Rows.Count - 1][0].ToString().Substring(2, 3));
        //        k = k + 1;
        //        if (k < 10)
        //        {
        //            ma = ma + "00";
        //        }
        //        else if (k < 100)
        //        {
        //            ma = ma + "0";
        //        }
        //        ma = ma + k.ToString();
        //    }
        //    return ma;
        //}


    }
}
