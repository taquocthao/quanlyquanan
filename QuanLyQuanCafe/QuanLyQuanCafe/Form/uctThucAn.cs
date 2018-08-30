using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS;
using DevExpress.XtraEditors;

namespace QuanLyQuanCafe.Form
{
    public partial class uctThucAn : UserControl
    {
        public static uctThucAn uct = new uctThucAn();

        //public static ThucAnNhanhBUS food = new ThucAnNhanhBUS();
       
        //private ThucAnNhanhBUS foodBus = new ThucAnNhanhBUS();
        public uctThucAn()
        {
            InitializeComponent();
        }

        //void ShowFood()
        //{
        //    flypnlFood.Controls.Clear();
        //    List<ThucAnNhanh> listFOOD = food.HienThiThucAnNhanh();

        //    foreach(ThucAnNhanh item in listFOOD)
        //    {
        //        ThemFoodCoSan(item);
        //    }
        //}

        //private void ThemFoodCoSan(ThucAnNhanh monAn)
        //{
        //    uctMonAn food = new uctMonAn(monAn);
        //    food.getButton().MouseClick += new MouseEventHandler(uctMonAn_click);
        //    flypnlFood.Controls.Add(food);
        //}
        //void uctMonAn_click(object sender, EventArgs e)
        //{            
        //    Control uctContainButton = (Control)sender;
        //    selectedUct = (uctMonAn)uctContainButton.Parent;
        //    if (selectedUct.monAn != null)
        //    {
        //        txtDonGia.Text = selectedUct.monAn.donGia.Value.ToString();
        //        txtMaThucAn.Text = selectedUct.monAn.maMA;
        //        txtTenThucAn.Text = selectedUct.monAn.tenMA;
        //    }
        //}
        //private void uctThucAn_Load(object sender, EventArgs e)
        //{
        //    ShowFood();
        //}
        
        //public void XoaMonAn(String maMonAn)
        //{
        //    foreach (uctMonAn u in flypnlFood.Controls)
        //    {
        //        if (maMonAn == u.monAn.maMA)
        //        {
        //            flypnlFood.Controls.Remove(u);
        //            u.Dispose();
        //            food.XoaThucAnNhanh(maMonAn);
        //        }
        //    }
        //}
        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    XoaMonAn(txtMaThucAn.Text);
        //}

        //private void btnThem_Click(object sender, EventArgs e)
        //{

        //    ThucAnNhanh monAn = new ThucAnNhanh();
        //    try
        //    {
        //        monAn.donGia = Convert.ToDecimal(txtDonGia.Text);
        //    }
        //    catch { MessageBox.Show("Chỉ cho phép số với đơn giá"); return; }
            
        //    monAn.tenMA = txtTenThucAn.Text;
        //    ThemFoodCoSan(monAn);
        //    if (monAn.maMA == txtMaThucAn.Text)
        //    {
        //        MessageBox.Show("Trùng mã thức ăn (ko đc giống nhau)");
        //    }
        //    food.ThemThucAnNhanh(monAn);
        //}

        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    ThucAnNhanh thucAn = new ThucAnNhanh();
        //    thucAn.tenMA = txtTenThucAn.Text;
        //    thucAn.maMA = txtMaThucAn.Text;

        //    try
        //    {
        //        thucAn.donGia = Convert.ToDecimal(txtDonGia.Text);
        //    }
        //    catch { MessageBox.Show("Chỉ cho phép số với đơn giá"); return; }
        //    food.CapNhatThucAnNhanh(thucAn);
        //    ShowFood();
        //}

        //private void panelControl2_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
