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
    public partial class frmLoaiHang : Form
    {
        public frmLoaiHang()
        {
            InitializeComponent();
        }

        LoaiHang lh = new LoaiHang();
        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        public void HienThi()
        {
            dataGridView1.DataSource = lh.ShowLoaiHang();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            Init();
        }
        public void Init()
        {
            if (dataGridView1.RowCount > 1)
            {
                try
                {
                    txtMaLH.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    txtTenLH.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                }
                catch { }
            }
        }
        public void SetNull()
        {
            txtMaLH.Text = "";
            txtTenLH.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SetNull();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
