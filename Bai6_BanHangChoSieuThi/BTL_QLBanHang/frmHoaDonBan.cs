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
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        int dong = 0;
        HoaDonBan hdb = new HoaDonBan();
        ChiTietHoaDonBan cthdb = new ChiTietHoaDonBan();
        SanPham sp = new SanPham();
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            HienThi();

        }

        public void HienThi()
        {
            dgvHoaDon.DataSource = hdb.HienThiHDB();
            for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                dgvHoaDon.Rows[i].Cells[0].Value = (i + 1).ToString();

            dgvCTHD.DataSource = cthdb.HienThiCTHDB();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvCTHD.DataSource = cthdb.HienThiCTHDB(dgvHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString());
                dong = e.RowIndex;
            }
            catch { }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hdb.HienThiHDB(DateTime.Parse(dateTimePicker1Ngay.Text));
            for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                dgvHoaDon.Rows[i].Cells[0].Value = (i + 1).ToString();
        }

        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThi();
        }

      
    }
}
