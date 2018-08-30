using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS;
using DevExpress.XtraEditors.Controls;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.Form
{
    public partial class uctBan : UserControl
    {
        public static uctBan uct = new uctBan();
        private BanBUS ban = new BanBUS();
        private bool isAdd = false;


        public uctBan()
        {
            InitializeComponent();

            init();
        }

        //private void ReloadForm()
        //{
        //    uctGoiMon uct = new uctGoiMon();
        //    uct.CapNhatTrangThaiBan += uct_CapNhatTrangThaiBan;
        //}

        //private void uct_CapNhatTrangThaiBan(object sender, EventArgs e)
        //{
            
        //}

        public void init()
        {
            HienThiDanhSachKhuVuc();            
            EnableProject(false);
            
        }
        private void HienThiDanhSachKhuVuc()
        {
            cboKhuVuc.DataSource = ban.HienThiDanhSachKhuVuc();
            cboKhuVuc.DisplayMember = "tenKhuVuc";
            cboKhuVuc.ValueMember = "maKhuVuc";

        }

        private void HienThiDanhSachBanTheoKhuVuc(int id)
        {
            flpDanhSachBan.Controls.Clear();
            List<Ban> listTable = ban.HienThiDanhSachBanTheoKhuVuc(id);
            foreach (Ban table in listTable)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = table.tenBan + Environment.NewLine + table.trangThai;
                btn.Click += btn_Click;
                btn.Tag = table;
                if (table.trangThai == "Trống")
                {
                    btn.BackColor = Color.Green;
                }
                else
                {
                    btn.BackColor = Color.Pink;
                }
                flpDanhSachBan.Controls.Add(btn);
            }

        }

      

        private void EnableProject(bool e)
        {
            if (e == true)
            {
                pnlTextfield.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                cboKhuVuc.Enabled = false;
                flpDanhSachBan.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
   
            }
            else if (e == false)
            {
                pnlTextfield.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                flpDanhSachBan.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                cboKhuVuc.Enabled = true;
            }
        }

        public void HienThiThongTinBan(int id)
        {
            Ban x = new Ban();
            x = ban.HienThiThongTinBan(id);
            txtMaBan.Text = x.maBan.ToString();
            txtTenBan.Text = x.tenBan;
            cboTrangThai.Text = x.trangThai;
            cboKhuVuc.Text = x.KhuVuc.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as Ban).maBan;
            HienThiThongTinBan(id);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            EnableProject(true);
            txtMaBan.Text = "Tự tăng";
            txtTenBan.Text = null;
            cboTrangThai.Text = "Trống";
            numSoLuongBan.Value = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isAdd = false;
            EnableProject(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaBan.Text);
            if (ban.XoaBan(id) == true)
                MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Xóa bàn không thành công, kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (flpDanhSachBan.Controls.Count > 0)
            {
                HienThiDanhSachBanTheoKhuVuc(Convert.ToInt32(cboKhuVuc.SelectedValue.ToString()));
            }
            else
                return;
                
                
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {            
            if(isAdd) // thêm thông tin bàn
            {
                Ban b = new Ban();
                //b.maBan = Convert.ToInt32(txtMaBan.Text);
                b.tenBan = txtTenBan.Text;
                b.trangThai = cboTrangThai.Text;
                b.maKhuVuc = Convert.ToInt32(cboKhuVuc.SelectedValue.ToString());
                if (ban.ThemBan(b) == true)
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // sai thông tin
                {
                    MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // cập nhật thông tin bàn
            {
                Ban b = new Ban();
                b.maKhuVuc = Convert.ToInt32(cboKhuVuc.SelectedValue);
                b.maBan = Convert.ToInt32(txtMaBan.Text);
                b.tenBan = txtTenBan.Text;
                b.trangThai = cboTrangThai.Text;
                if (ban.SuaBan(b) == true)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // sai thông tin
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            EnableProject(false);
            HienThiDanhSachBanTheoKhuVuc(Convert.ToInt32(cboKhuVuc.SelectedValue.ToString()));
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EnableProject(false);
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idKhuVuc = (cboKhuVuc.SelectedItem as KhuVuc).maKhuVuc;
            HienThiDanhSachBanTheoKhuVuc(idKhuVuc);
        }



    }
}
