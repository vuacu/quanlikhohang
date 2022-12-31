using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QuanLyKho041
{
    public partial class QLNhanVien : Form
    {
        NhanVienBLL NVBLL = new NhanVienBLL();
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NVBLL.LayTatCa();
        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            ThemNV frmt = new ThemNV();
            this.Hide();
            frmt.Show();
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            SuaNV frm = new SuaNV();
            this.Hide();
            frm.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_d.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void btn_d_Click(object sender, EventArgs e)
        {
            try
            {
                NVBLL.xoa_nv(int.Parse(txt_id_d.Text));
                MessageBox.Show("xoa thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QLNhanVien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message, "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
