using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Form
{
    public partial class uctThongTinThucPham : UserControl
    {
        public uctThongTinThucPham()
        {
            InitializeComponent();
        }

        public Button getButton()
        {
            return this.button1;
        }

        public NumericUpDown getNumericUpDown()
        {
            return this.numericUpDown1;
        }
    }
}
