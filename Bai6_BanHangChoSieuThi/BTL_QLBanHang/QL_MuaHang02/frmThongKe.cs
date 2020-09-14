using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace QuanLyBanHang
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        SanPham sp = new SanPham();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 6) dateTimePicker1.Enabled = dateTimePicker2.Enabled = true;
            else dateTimePicker1.Enabled = dateTimePicker2.Enabled = false;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
           
        }
    }
}
