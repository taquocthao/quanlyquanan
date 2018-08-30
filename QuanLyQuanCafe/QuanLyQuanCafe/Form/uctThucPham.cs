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
    public partial class uctThucPham : UserControl
    {
        public static uctThucPham uct = new uctThucPham();
        private ThucPhamBUS food = new ThucPhamBUS();
        private static bool isADD = false;

        public uctThucPham()
        {
            InitializeComponent();
            HienThiDanhSachLoaiThucPham();
            HienThiDanhSachThucPhamTheoLoai(Convert.ToInt32(cbLoaiThucPham.SelectedValue));
            EnableProject(false);
            
        }

        #region function xử lý, giao diện
        //
        private void HienThiDanhSachThucPham()
        {
            flpDanhSachThucPham.Controls.Clear();
            var list = food.HienThiDanhSachThucPham();
            foreach (ThucPham x in list)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = x.tenTP + Environment.NewLine + x.donGia;
                btn.BackColor = Color.LightSkyBlue;
                flpDanhSachThucPham.Controls.Add(btn);
            }

        }

        private void HienThiDanhSachThucPhamTheoLoai(int id)
        {
            flpDanhSachThucPham.Controls.Clear();
            var list = food.HienThiDanhSachThucPhamTheoLoai(id);
            foreach (ThucPham x in list)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = x.tenTP + Environment.NewLine + x.donGia;
                btn.BackColor = Color.LightSkyBlue;
                btn.Click += btn_Click;
                btn.Tag = x;
                flpDanhSachThucPham.Controls.Add(btn);
            }
        }

        private void HienThiThongTinThucPham(int id)
        {
            ThucPham x = new ThucPham();
            x = food.HienThiThongTinThucPham(id);
            txtMaThucPham.Text = x.maTP.ToString();
            txtTenThucPham.Text = x.tenTP;
            txtDonGia.Text = x.donGia.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as ThucPham).maTP;
            HienThiThongTinThucPham(id);
        }

        private void HienThiDanhSachLoaiThucPham()
        {
            cbLoaiThucPham.DataSource = food.HienThiDanhSachLoaiThucPham();
            cbLoaiThucPham.DisplayMember = "tenLoaiTP";
            cbLoaiThucPham.ValueMember = "maLoaiTp";
        }


        private void EnableProject(bool e)
        {
            if (e == true)
            {
                pnlTextField.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                flpDanhSachThucPham.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                cbLoaiThucPham.Enabled = false;
            }
            else if (e == false)
            {
                pnlTextField.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                flpDanhSachThucPham.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                cbLoaiThucPham.Enabled = true;
            }
        }

        //
        #endregion

        #region thao tác, thêm xóa sửa

        private void btnThem_Click(object sender, EventArgs e)
        {
            isADD = true;
            EnableProject(true);
            txtMaThucPham.Text = "Tự tăng";
            txtTenThucPham.Text = null;
            txtDonGia.Text = null;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isADD = false;
            EnableProject(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaThucPham.Text.Trim());
            bool success = food.XoaThucPham(id);
            if (success)
            {
                MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HienThiDanhSachThucPhamTheoLoai(Convert.ToInt32(cbLoaiThucPham.SelectedItem));

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isADD)// nếu thêm thực phẩm
            {
                ThucPham x = new ThucPham();
                x.maLoaiTP = Convert.ToInt32(cbLoaiThucPham.SelectedValue.ToString());
               // x.maTP = Convert.ToInt32(txtMaThucPham.Text);
                x.tenTP = txtTenThucPham.Text;
                x.donGia = Convert.ToDecimal(txtDonGia.Text);
                bool success = food.ThemThucPham(x);
                if (success)
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // nếu sửa thực phẩm
            {
                ThucPham x = new ThucPham();
                x.maLoaiTP = Convert.ToInt32(cbLoaiThucPham.SelectedValue.ToString());
                 x.maTP = Convert.ToInt32(txtMaThucPham.Text);
                x.tenTP = txtTenThucPham.Text;
                x.donGia = Convert.ToDecimal(txtDonGia.Text);
                bool success = food.SuaThucPham(x);
                if (success == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            EnableProject(false);
            HienThiDanhSachThucPhamTheoLoai(Convert.ToInt32(cbLoaiThucPham.SelectedValue));
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EnableProject(false);
            HienThiDanhSachThucPhamTheoLoai(Convert.ToInt32(cbLoaiThucPham.SelectedValue));
        }


        private void cbLoaiThucPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idLoaiTP = (cbLoaiThucPham.SelectedItem as LoaiThucPham).maLoaiTP;
            HienThiDanhSachThucPhamTheoLoai(idLoaiTP);
        }

        //kiểm tra input -> nếu là chữ thì không cho nhập, chỉ được nhập số
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

      

       


        

    }
}
