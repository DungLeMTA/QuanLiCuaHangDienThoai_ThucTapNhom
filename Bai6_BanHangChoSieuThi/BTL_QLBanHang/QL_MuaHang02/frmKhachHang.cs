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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        KhachHang kh = new KhachHang();
        int temp = 0;

        private void KhachHang_Load(object sender, EventArgs e)
        {
            DKOThongTin(false);
            setNULL();
            HienThiDGV();
        }

        public void DKOThongTin(bool bl)
        {
            txttenKH.Enabled = txtSoDT.Enabled = txtMaKH.Enabled = txtDC.Enabled = cmbLoaiKH.Enabled = bl;
            cmbGioiTinh.Enabled = txtGhichu.Enabled = bl;
        }
        public void setNULL()
        {
            txtMaKH.Text = txtDC.Text = txtSoDT.Text = txttenKH.Text = cmbGioiTinh.Text = txtGhichu.Text = "";
            cmbLoaiKH.Text = "Khách Lẻ";
            temp = 0;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }
        public void HienThiDGV()
        {
               dgvKhachHang.DataSource = kh.HienThiKhachHang();
               int i = 0;
               while (i < dgvKhachHang.Rows.Count - 1)
               {
                    dgvKhachHang.Rows[i].Cells[0].Value = (i + 1).ToString();
                    i++;
               }
          }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void txtKHten_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbKHLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtKHDiaChi_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
           
        }
    }
}
