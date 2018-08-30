using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS;
using System.Globalization;

namespace QuanLyQuanCafe.Form
{
    public partial class uctThongKeHoaDon : UserControl
    {
        public static uctThongKeHoaDon uct = new uctThongKeHoaDon();
        private HoaDonBUS hoadon = new HoaDonBUS();
        private CultureInfo culture = new CultureInfo("vi-VN");
        public uctThongKeHoaDon()
        {
            InitializeComponent();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            //DateTime startdate = Convert.ToDateTime(dateEdit1.EditValue);
            //DateTime enddate = Convert.ToDateTime(dateEdit2.EditValue);
            //if (startdate.Equals() || enddate.Equals("1/1/0001 12:00:00 SA"))
            //{
            //    MessageBox.Show("Chưa có thời gian để thống kê!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    if (startdate > enddate)
            //    {
            //        MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    gridControl1.DataSource = hoadon.HienThiDanhSachHoaDon(startdate, enddate);  
            //}
              
        }
    }
}
