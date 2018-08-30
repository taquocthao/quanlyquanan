using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyQuanCafe.Form
{
    public partial class CustomsMessageBox : DevExpress.XtraEditors.XtraForm
    {
        private int soLuong = 1;
        public CustomsMessageBox()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            lblThongBao.Text = "Thực đơn đã được gọi! bạn có muốn tiếp tục thêm vào danh sách?";        
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            soLuong = (int)nudSoLuong.Value;
            uctGoiMon.getNumber = soLuong;
            this.Close();
        }


    }
}